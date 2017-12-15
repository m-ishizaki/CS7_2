using cs72console.Features;
using System;
using System.Linq;

namespace cs72console
{
    class Program
    {
        static void Main(string[] args)
        {
            var features = new IMain[]
            {
                new Span(),
                new ReadonlyStruct(),
                new InParametersRefReadonlyReturns(),
                new PrivateProtected(),
                new NonTrailingNamedArguments(),
                new AllowDigitSeparatorAfter0bOr0x(),
                new ConditionalRefOperator(),
                new RefExtensionMethodsOnStructs(),
            };
            foreach (var f in features.Select((m, index) => new { Index = index, Feature = m }))
                Console.WriteLine($"{f.Index}:{f.Feature.GetType().Name}");

            var key = Console.ReadKey();

            Console.WriteLine();

            if (int.TryParse(key.KeyChar.ToString(), out int i))
            {
                var f = features[i];
                Console.WriteLine(f.GetType().Name);
                f.Main();
            }

            Console.ReadKey();
        }
    }
}
