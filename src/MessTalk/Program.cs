using System;
using System.IO;
using MessTalk.Models;
using Mustache;
using PowerArgs;
using YamlDotNet.RepresentationModel;

namespace MessTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("MessTalk {0}.{1}. Copyright BitTacklr {2}.", 
                    typeof(Program).Assembly.GetName().Version.Major,
                    typeof(Program).Assembly.GetName().Version.Minor,
                    DateTimeOffset.UtcNow.Date.Year);
                var parsed = Args.Parse<ProgramArguments>(args);
                var model = ParseModel(parsed.Input);
                var output = TransformModel(model, parsed.Template);
                File.WriteAllText(parsed.Output, output);
                Environment.Exit(0);
            }
            catch (ArgException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ArgUsage.GenerateUsageFromTemplate<ProgramArguments>());
                Environment.Exit(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(-1);
            }
        }

        private static string TransformModel(NamedModel model, string template)
        {
            if (model == null) throw new ArgumentNullException("model");
            if (template == null) throw new ArgumentNullException("template");
            var compiler = new FormatCompiler();
            var generator = compiler.Compile(File.ReadAllText(template));
            return generator.Render(model);
        }

        private static NamedModel ParseModel(string input)
        {
            if (input == null) throw new ArgumentNullException("input");
            using (var yamlSource = File.OpenText(input))
            {
                var stream = new YamlStream();
                stream.Load(yamlSource);
                var visitor = new ComposeNamedModelVisitor();
                stream.Accept(visitor);
                return visitor.Model;
            }
        }


        class ProgramArguments
        {
            [ArgRequired, ArgDescription("The yaml file containing the named model.")]
            public string Input { get; set; }
            [ArgRequired, ArgDescription("The mustache file containing the code to be generated based on the named model.")]
            public string Template { get; set; }
            [ArgRequired, ArgDescription("The output file that contains the generated code.")]
            public string Output { get; set; }
        }
    }
}