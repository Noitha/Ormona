namespace Ormona.Planets
{
    public struct NeighbourPatterns
    {
        public byte leftPattern;
        public byte rightPattern;
        public byte bottomPattern;
        public byte topPattern;
        public byte backPattern;
        public byte frontPattern;

        public NeighbourPatterns(byte leftPattern, byte rightPattern, byte bottomPattern, byte topPattern, byte backPattern, byte frontPattern)
        {
            this.leftPattern = leftPattern;
            this.rightPattern = rightPattern;
            this.bottomPattern = bottomPattern;
            this.topPattern = topPattern;
            this.backPattern = backPattern;
            this.frontPattern = frontPattern;
        }
    }
}