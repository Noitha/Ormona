using UnityEngine;

namespace Ormona.Planets.Scripts
{
    public static class Generation
    {
        public static int Generate2DGrass(int worldX, int worldZ, float seed)
        {
            var lol = FractalBrownianMotion2D(worldX, worldZ, 2, 0.55f, seed);

            return (int) Map
            (
                90, 
                125, 
                FractalBrownianMotion2D
                (
                    worldX * Map(0.01f, 0.025f, lol), 
                    worldZ * Map(0.01f, 0.025f, lol), 
                    2,
                    .632f,
                    seed
                )
            );
        }

        
        public static int Generate2DSand(int worldX, int worldZ, float seed)
        {
            var lol = FractalBrownianMotion2D(worldX, worldZ, 2, 0.55f, seed);

            return (int) Map
            (
                89, 
                124, 
                FractalBrownianMotion2D
                (
                    worldX * Map(0.01f, 0.025f, lol), 
                    worldZ * Map(0.01f, 0.025f, lol), 
                    2,
                    .632f,
                    seed
                )
            );
        }
        
        
        
        
        
        
        

        private static float Map(float min, float max, float value)
        {
            return Mathf.Lerp (min, max, Mathf.InverseLerp (0, 1, value));
        }

        private static float FractalBrownianMotion2D(float x, float z, int octaves, float persistence, float seed)
        {
            float frequency = 1;
            float amplitude = 1;
            float total = 0;

            const int offset = 238641;
            
            for(var i = 0; i < octaves ; i++)
            {
                var perlinX = (x + offset) * frequency;
                var perlinZ = (z + offset) * frequency;
                
                
                total += Mathf.PerlinNoise(perlinX, perlinZ) * amplitude;

                amplitude *= persistence;
                frequency *= 2;
            }
            return total / octaves;
        }
        
        public static float FractalBrownianMotion3D(float x, float y, float z, float smooth, int octaves, float seed)
        {
            var xy = FractalBrownianMotion2D(x * smooth,y * smooth, octaves,0.5f, seed);
            var yz = FractalBrownianMotion2D(y * smooth,z * smooth, octaves,0.5f, seed);
            var xz = FractalBrownianMotion2D(x * smooth,z * smooth, octaves,0.5f, seed);

            var yx = FractalBrownianMotion2D(y * smooth,x * smooth, octaves,0.5f, seed);
            var zy = FractalBrownianMotion2D(z * smooth,y * smooth, octaves,0.5f, seed);
            var zx = FractalBrownianMotion2D(z * smooth,x * smooth, octaves,0.5f, seed);


            var result = (xy + yz + xz + yx + zy + zx) / 6.0f;
            return result;
        }
    }
}