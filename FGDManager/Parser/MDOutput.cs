namespace FGDManager
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class MDOutput
    {
        private List<string> commonKeyvalues = new List<string>()
        {
            "target",
            "targetname",
            "name",
            "angles",
            "ondestroyfn",
            "killtarget",
            "delay",
            "master",
            "tinfilter",
            "tinfiltertype",
            "cinfilter",
            "cinfiltertype",
            "toutfilter",
            "toutfiltertype",
            "coutfilter",
            "coutfiltertype",
            "globalname",
        };

        public void GenerateOutput(List<Entity> entities)
        {
            var dir = "output";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            foreach (var entity in entities)
            {
                if (entity.Type != EntityType.Point && entity.Type != EntityType.Solid)
                    continue;
                
                var subdir = string.Format("output\\{0}", entity.ClassName);
                if (!Directory.Exists(subdir))
                {
                    Directory.CreateDirectory(subdir);
                }
                var fileName = string.Format("output\\{0}\\entity.md", entity.ClassName);

                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("---");
                    writer.WriteLine($"title: {entity.ClassName}");
                    writer.WriteLine("---");
                    writer.WriteLine("<div>{% set entname = page.title|raw %}</div>");
                    writer.WriteLine("<div class=\"container previewimg\">");
                    writer.WriteLine("<div class=\"columns\">");
                    writer.WriteLine("<div class=\"imagepadding column col-auto\" markdown=\"1\">![](preview.png)</div>");
                    writer.WriteLine($"<div class=\"column entityentry\" markdown=\"1\">{entity.Description}</div>");
                    writer.WriteLine("</div>");
                    writer.WriteLine("</div>");
                    
                    var allKeyValues = entity.FinalKeyValues;
                    allKeyValues.RemoveAll(a => a.Name == "spawnflags");
                    
                    
                    if (allKeyValues.Count > 0)
                    {
                        writer.WriteLine("<div>");
                        writer.WriteLine("<table class=\"titletable\">");
                        writer.WriteLine("<tbody>");
                        writer.WriteLine("<tr>");
                        writer.WriteLine("<td markdown=\"1\">###Keyvalues</td>");
                        writer.WriteLine("<td class=\"titletablecheck\" id=\"checkboxandlabel\"><input type=\"checkbox\" id=\"displaycommon\"><label for=\"displaycommon\"> Display Common Keyvalues</label></input></td>");
                        writer.WriteLine("</tr>");
                        writer.WriteLine("</tbody>");
                        writer.WriteLine("</table>");
                        writer.WriteLine("<hr>");
                        var accordionIndex = 1;
                        var currentGroup = string.Empty;
                        var groupOpened = false;

                        foreach (var key in allKeyValues)
                        {
                            if (key.Group != currentGroup)
                            {
                                if (groupOpened)
                                {
                                    currentGroup = string.Empty; // It may be null
                                    groupOpened = false;
                                    writer.WriteLine("</div>");
                                    writer.WriteLine("</div>");
                                }

                                if (!string.IsNullOrEmpty(key.Group))
                                {
                                    groupOpened = true;
                                    currentGroup = key.Group;
                                    writer.WriteLine("<div class=\"accordion entityentry\">");
                                    writer.WriteLine($"<input type=\"checkbox\" id=\"accordion-{accordionIndex}\" name=\"accordion-checkbox\" hidden>");
                                    writer.WriteLine($"<label class=\"accordion-header\" for=\"accordion-{accordionIndex}\">");
                                    writer.WriteLine($"<span style=\"color:#cae4fc;\"><b>{key.Group}</b></span>");
                                    writer.WriteLine("<i class=\"icon icon-arrow-right mr-1\"></i>");
                                    writer.WriteLine("</label>");
                                    writer.WriteLine("<div class=\"accordion-body entgroup\">");
                                    accordionIndex++;
                                }
                            }

                            var entityEntryClasses = "entityentry";

                            if (commonKeyvalues.Any(a => a == key.Name))
                            {
                                entityEntryClasses = "entityentry commonkeys-checkbox";
                            }

                            writer.WriteLine($"<div class=\"{entityEntryClasses}\" markdown=\"1\">");
                            writer.WriteLine($"<span style=\"color:#9fc5e8;\"><b>{key.DocName}</b></span> <kbd  class=\"tooltip\" data-tooltip=\"{key.Type}\">{key.Name}</kbd> :");
                            
                            var keyMedia = string.IsNullOrEmpty(key.Media) ? "" : $"<div class=\"imagepadding\" markdown=\"1\">![{key.DocName}]({key.Media})</div>";
                            writer.WriteLine($"{entity.GetDescriptionForKey(key)}{keyMedia}");
                            if (key.Choices.Count > 0)
                            {
                                writer.WriteLine("<div class=\"accordion\">");
                                writer.WriteLine($"<input type=\"checkbox\" id=\"accordion-{accordionIndex}\" name=\"accordion-checkbox\" hidden>");
                                writer.WriteLine($"<label class=\"accordion-header\" for=\"accordion-{accordionIndex}\">");
                                writer.WriteLine("<i class=\"icon icon-arrow-right mr-1\"></i>");
                                writer.WriteLine("Choices:");
                                writer.WriteLine("</label>");
                                writer.WriteLine("<div class=\"accordion-body\">");
                                writer.WriteLine("<ul>");
                                foreach (var choice in key.Choices)
                                {
                                    var description = string.IsNullOrEmpty(choice.Description) ? "" : $" : {choice.Description}";
                                    var choiceMedia = string.IsNullOrEmpty(choice.Media) ? "" : $"<div class=\"imagepadding\" markdown=\"1\">![{choice.DocName}]({choice.Media})</div>";
                                    if (choice.Value == $"\"{choice.DocName}\"") 
                                    {
                                        writer.WriteLine($"<li><b>{choice.Value}</b> {description}{choiceMedia}</li>");
                                    }
                                    else 
                                    {
                                        writer.WriteLine($"<li><b>{choice.Value}</b> : {choice.DocName}{description}{choiceMedia}</li>");
                                    }
                                }
                                writer.WriteLine("</ul>");
                                writer.WriteLine("</div>");
                                writer.WriteLine("</div>");
                                accordionIndex++;
                            }
                            writer.WriteLine("</div>");
                        }
                    }

                    writer.WriteLine("</div>");

                    if (entity.SpawnFlags.Count > 0)
                    {
                        writer.WriteLine("###Flags");
                        writer.WriteLine("<hr>");
                        writer.WriteLine("<div class=\"entityflags\">");
                        writer.WriteLine("<ul>");
                        foreach (var flag in entity.SpawnFlags)
                        {
                            var description = string.IsNullOrEmpty(flag.Description) ? "" : $" : {flag.Description}";
                            writer.WriteLine($"<li class=\"imagepadding\" markdown=\"1\"><b>{flag.Value}</b> : <span style=\"color:#9fc5e8;\">{flag.DocName}</span>{description}</li>");
                        }
                        writer.WriteLine("</ul>");
                        writer.WriteLine("</div>");
                    }

                    foreach (var note in entity.Notes)
                    {
                        writer.WriteLine($"<div class=\"notices blue\" markdown=\"1\">{note}</div>");
                    }
                    
                    foreach (var issue in entity.Issues)
                    {
                        writer.WriteLine($"<div class=\"notices red\" markdown=\"1\">{issue}</div>");
                    }
                }
            }

            var pointEntitiesFile = "point_entities.txt";
            if (File.Exists(pointEntitiesFile))
            {
                File.Delete(pointEntitiesFile);
            }
            
            using (StreamWriter writer = new StreamWriter(pointEntitiesFile))
            {
                foreach (var point in entities.Where(a => a.Type == EntityType.Point))
                {
                    writer.WriteLine("[{0}]({0})", point.ClassName);
                }
            }
            
            var brushEntitiesFile = "solid_entities.txt";
            if (File.Exists(brushEntitiesFile))
            {
                File.Delete(brushEntitiesFile);
            }
            
            using (StreamWriter writer = new StreamWriter(brushEntitiesFile))
            {
                foreach (var brush in entities.Where(a => a.Type == EntityType.Solid))
                {
                    writer.WriteLine("[{0}]({0})", brush.ClassName);
                }
            }
        }
    }
}