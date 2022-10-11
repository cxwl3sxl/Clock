using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Clock
{
    class IniConfig
    {
        readonly List<ConfigSection> _sections = new List<ConfigSection>();
        private readonly Encoding _encoding;
        private readonly string _file;

        public IniConfig(string file, bool autoCreate = false, Encoding encoding = null)
        {
            if (!File.Exists(file))
            {
                if (!autoCreate) throw new FileNotFoundException("指定的文件不存在", file);
                File.Create(file).Close();
            }

            _file = file;
            _encoding = encoding ?? Encoding.UTF8;
            var lines = File.ReadAllLines(_file, _encoding);
            ConfigSection currentSection = null;
            foreach (var line in lines)
            {
                var trimLine = line.TrimStart();
                if (trimLine.Length > 0)
                {
                    switch (trimLine[0])
                    {
                        case '#': // 注释
                            if (currentSection == null)
                            {
                                currentSection = new ConfigSection("");
                                _sections.Add(currentSection);
                            }

                            currentSection.AddConfigLine(line);
                            break;
                        case '[': //section 开始
                            currentSection = new ConfigSection(line);
                            _sections.Add(currentSection);
                            break;
                        default:
                            currentSection?.AddConfigLine(line);
                            break;
                    }
                }
                else
                {
                    currentSection?.AddConfigLine(line);
                }
            }
        }

        public ConfigSection this[string sectionName]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(sectionName)) throw new ArgumentNullException(sectionName);
                var section = _sections.FirstOrDefault(a => a.Name == sectionName);
                if (section != null) return section;
                section = new ConfigSection(sectionName);
                _sections.Add(section);
                return section;
            }
        }

        public void Save()
        {
            var sb = new StringBuilder();
            foreach (var section in _sections)
            {
                if (!string.IsNullOrWhiteSpace(section.Name))
                {
                    sb.AppendLine("");
                    sb.AppendLine($"[{section.Name}]");
                }

                section.WriteSection(sb);
            }

            File.WriteAllText(_file, sb.ToString(), _encoding);
        }
    }

    class ConfigSection
    {
        private readonly List<ConfigLine> _values;

        public ConfigSection(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Name = name;
            }
            else
            {
                Name = name
                    .TrimStart()
                    .TrimEnd()
                    .Replace("[", "")
                    .Replace("]", "");
            }

            _values = new List<ConfigLine>();
        }

        internal void AddConfigLine(string content)
        {
            _values.Add(new ConfigLine(content));
        }

        public string Name { get; }

        public ConfigLine this[string name]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(name);
                var config = _values.FirstOrDefault(a => a.Name == name);
                if (config != null) return config;
                config = new ConfigLine($"{name}=");
                _values.Add(config);
                return config;
            }
        }

        internal void WriteSection(StringBuilder sb)
        {
            foreach (var line in _values)
            {
                sb.AppendLine(line.ToString());
            }
        }
    }

    class ConfigLine
    {
        public ConfigLine(string content)
        {
            if (!string.IsNullOrWhiteSpace(content))
            {
                var line = content.TrimStart().TrimEnd();
                if (line.StartsWith("#"))
                {
                    IsComment = true;
                    Value = content.Substring(1);
                }
                else
                {
                    var index = line.IndexOf('=');
                    Name = line.Substring(0, index);
                    Value = line.Substring(index + 1);
                }
            }
            else
            {
                Value = "";
            }
        }

        public string Name { get; }

        public string Value { get; set; }

        public bool IsComment { get; set; }

        public override string ToString()
        {
            return $"{(IsComment ? "#" : "")}{(string.IsNullOrWhiteSpace(Name) ? "" : $"{Name}=")}{Value}";
        }
    }
}
