using System.Collections.Generic;

namespace ComfileTech.ComfilePi.CP_IO19R
{
    /// <summary>
    /// Represents the CP-IO19R IO board connected to the ComfilePi.
    /// </summary>
    public class CP_IO19R
    {
        static CP_IO19R()
        {
            Instance = new CP_IO19R();
        }

        /// <summary>
        /// The singleton instance of this class.
        /// </summary>
        public static CP_IO19R Instance
        {
            get; private set;
        }

        private CP_IO19R()
        {
            // Create the digital inputs
            {
                var list = new List<DigitalInput>();
                for (int i = 4; i <= 13; i++)
                {
                    list.Add(new DigitalInput(i));
                }
                list.Add(new DigitalInput(16));
                DigitalInputs = list.AsReadOnly();
            }

            // Create the digital outputs
            {
                var list = new List<DigitalOutput>();
                for (int i = 17; i <= 24; i++)
                {
                    list.Add(new DigitalOutput(i));
                }
                Relays = list.AsReadOnly();
            }
        }

        /// <summary>
        /// The digital inputs for the IO board.
        /// </summary>
        public IReadOnlyList<DigitalInput> DigitalInputs
        {
            get;
        }

        /// <summary>
        /// The digital outputs for the IO board.
        /// </summary>
        public IReadOnlyList<DigitalOutput> Relays
        {
            get;
        }
    }
}
