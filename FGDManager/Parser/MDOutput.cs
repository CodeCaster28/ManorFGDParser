namespace FGDManager
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class MDOutput
    {
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