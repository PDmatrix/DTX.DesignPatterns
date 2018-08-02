using System;
using System.Collections.Generic;
using System.Text;

namespace DTX.DesignPatterns.Patterns.Composite
{
    public static class ClassicComposite
    {
        // Component
        private abstract class Component
        {
            protected readonly string Name;

            protected Component(string name)
            {
                Name = name;
            }

            public virtual void Add(Component component)
            {
                // Not used
            }

            public virtual void Remove(Component component)
            {
                // Not used
            }

            public virtual void Print()
            {
                Console.WriteLine(Name);
            }
        }

        // Composite
        private class Directory : Component
        {
            private readonly List<Component> _components = new List<Component>();

            public Directory(string name)
                : base(name)
            {

            }

            public override void Add(Component component)
            {
                _components.Add(component);
            }

            public override void Remove(Component component)
            {
                _components.Remove(component);
            }

            public override void Print()
            {
                Console.WriteLine($@"Composite: {Name}:{Environment.NewLine}");
                Console.WriteLine(@"Leafs:");
                foreach (var t in _components)
                {
                    t.Print();
                }
            }
        }

        // Leaf
        private class File : Component
        {
            public File(string name)
                : base(name)
            {

            }
        }

        // Client
        public static void Start()
        {
            Component fileSystem = new Directory("File System");
            Component diskC = new Directory("Disc C");
            Component pngFile = new File("12345.png");
            Component docxFile = new File("Document.docx");

            diskC.Add(pngFile);
            diskC.Add(docxFile);

            fileSystem.Add(diskC);
            fileSystem.Print();

            Console.WriteLine();

            diskC.Remove(pngFile);

            Component docsFolder = new Directory("My Documents");
            Component txtFile = new File("readme.txt");
            Component csFile = new File("Program.cs");

            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);

            diskC.Add(docsFolder);

            fileSystem.Print();
        }
    }
}