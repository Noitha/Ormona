using System;
using Ormona.Planets.Scripts;
using UnityEngine;

namespace Ormona.Planets.Meshes
{
    public static class MeshCreation
    {
        /// <summary>
        /// Create a 90° degree triangle.
        /// </summary>
        /// <returns></returns>
        public static Mesh CreateRectangleTriangle(Direction direction, TriangleOrigin triangleOrigin)
        {
            Vector3 point1;
            Vector3 point2;
            Vector3 point3;

            int[] triangles;
            
            Vector2 uv1;
            Vector2 uv2;
            Vector2 uv3;

            Vector3 normal1;
            Vector3 normal2;
            Vector3 normal3;

            switch (direction)
            {
                case Direction.Left:
                    switch (triangleOrigin)
                    {
                        case TriangleOrigin.MMOut:
                            point1 = new Vector3(-.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, .5f);
                            point3 = new Vector3(-.5f, .5f, -.5f);
                                  
                            triangles = new[]
                            {
                                0,1,2
                            };
                                                              
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                                  
                        case TriangleOrigin.MPOut:
                            point1 = new Vector3(-.5f, 0, .5f);
                            point2 = new Vector3(-.5f, .5f, .5f);
                            point3 = new Vector3(-.5f, 0, -.5f);
                                                              
                            triangles = new[]
                            {
                                0,1,2
                            };
                                                              
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                                  
                        case TriangleOrigin.PMOut:
                            point1 = new Vector3(-.5f, .5f, -.5f);
                            point2 = new Vector3(-.5f, 0, -.5f);
                            point3 = new Vector3(-.5f, .5f, .5f);
                                                              
                            triangles = new[]
                            {
                                0,1,2
                            };
                                                              
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                                  
                        case TriangleOrigin.PPOut:
                            point1 = new Vector3(-.5f, .5f, .5f);
                            point2 = new Vector3(-.5f, .5f, -.5f);
                            point3 = new Vector3(-.5f, 0, .5f);
                                                              
                            triangles = new[]
                            {
                                0,1,2
                            };
                                                              
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                        
                        case TriangleOrigin.MMIn:
                            point1 = new Vector3(-.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, .5f);
                            point3 = new Vector3(-.5f, .5f, -.5f);
                                  
                            triangles = new[]
                            {
                                2,1,0
                            };
                                                              
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                                  
                        case TriangleOrigin.MPIn:
                            point1 = new Vector3(-.5f, 0, .5f);
                            point2 = new Vector3(-.5f, .5f, .5f);
                            point3 = new Vector3(-.5f, 0, -.5f);
                                                              
                            triangles = new[]
                            {
                                2,1,0
                            };
                                                              
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                                  
                        case TriangleOrigin.PMIn:
                            point1 = new Vector3(-.5f, .5f, -.5f);
                            point2 = new Vector3(-.5f, 0, -.5f);
                            point3 = new Vector3(-.5f, .5f, .5f);
                                                              
                            triangles = new[]
                            {
                                2,1,0
                            };
                                                              
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                                  
                        case TriangleOrigin.PPIn:
                            point1 = new Vector3(-.5f, .5f, .5f);
                            point2 = new Vector3(-.5f, .5f, -.5f);
                            point3 = new Vector3(-.5f, 0, .5f);
                                                              
                            triangles = new[]
                            {
                                2,1,0
                            };
                                                              
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
                    }
                    break;

                case Direction.Right:
                    switch (triangleOrigin)
                    {
                        case TriangleOrigin.MMOut:
                            point1 = new Vector3(.5f, 0, -.5f);
                            point2 = new Vector3(.5f, .5f, -.5f);
                            point3 = new Vector3(.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        case TriangleOrigin.MPOut:
                            point1 = new Vector3(.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, -.5f);
                            point3 = new Vector3(.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        case TriangleOrigin.PMOut:
                            point1 = new Vector3(.5f, .5f, -.5f);
                            point2 = new Vector3(.5f, .5f, .5f);
                            point3 = new Vector3(.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        case TriangleOrigin.PPOut:
                            point1 = new Vector3(.5f, .5f, .5f);
                            point2 = new Vector3(.5f, 0, .5f);
                            point3 = new Vector3(.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;
                        
                        case TriangleOrigin.MMIn:
                            point1 = new Vector3(.5f, 0, -.5f);
                            point2 = new Vector3(.5f, .5f, -.5f);
                            point3 = new Vector3(.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        case TriangleOrigin.MPIn:
                            point1 = new Vector3(.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, -.5f);
                            point3 = new Vector3(.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        case TriangleOrigin.PMIn:
                            point1 = new Vector3(.5f, .5f, -.5f);
                            point2 = new Vector3(.5f, .5f, .5f);
                            point3 = new Vector3(.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        case TriangleOrigin.PPIn:
                            point1 = new Vector3(.5f, .5f, .5f);
                            point2 = new Vector3(.5f, 0, .5f);
                            point3 = new Vector3(.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
                    }
                    break;

                case Direction.Bottom:
                    switch (triangleOrigin)
                    {
                        case TriangleOrigin.MMOut:
                            point1 = new Vector3(-.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, .5f);
                            point3 = new Vector3(.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        case TriangleOrigin.MPOut:
                            point1 = new Vector3(-.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, .5f);
                            point3 = new Vector3(-.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        case TriangleOrigin.PMOut:
                            point1 = new Vector3(.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, -.5f);
                            point3 = new Vector3(.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        case TriangleOrigin.PPOut:
                            point1 = new Vector3(.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, -.5f);
                            point3 = new Vector3(-.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;
                        
                        case TriangleOrigin.MMIn:
                            point1 = new Vector3(-.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, .5f);
                            point3 = new Vector3(.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        case TriangleOrigin.MPIn:
                            point1 = new Vector3(-.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, .5f);
                            point3 = new Vector3(-.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        case TriangleOrigin.PMIn:
                            point1 = new Vector3(.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, -.5f);
                            point3 = new Vector3(.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        case TriangleOrigin.PPIn:
                            point1 = new Vector3(.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, -.5f);
                            point3 = new Vector3(-.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
                    }
                    break;

                case Direction.Top:
                    switch (triangleOrigin)
                    {
                        case TriangleOrigin.MMOut:
                            point1 = new Vector3(-.5f, .5f, -.5f);
                            point2 = new Vector3(-.5f, .5f, .5f);
                            point3 = new Vector3(.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        case TriangleOrigin.MPOut:
                            point1 = new Vector3(-.5f, .5f, .5f);
                            point2 = new Vector3(.5f, .5f, .5f);
                            point3 = new Vector3(-.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        case TriangleOrigin.PMOut:
                            point1 = new Vector3(.5f, .5f, -.5f);
                            point2 = new Vector3(-.5f, .5f, -.5f);
                            point3 = new Vector3(.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        case TriangleOrigin.PPOut:
                            point1 = new Vector3(.5f, .5f, .5f);
                            point2 = new Vector3(.5f, .5f, -.5f);
                            point3 = new Vector3(-.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;
                        
                        case TriangleOrigin.MMIn:
                            point1 = new Vector3(-.5f, .5f, -.5f);
                            point2 = new Vector3(-.5f, .5f, .5f);
                            point3 = new Vector3(.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        case TriangleOrigin.MPIn:
                            point1 = new Vector3(-.5f, .5f, .5f);
                            point2 = new Vector3(.5f, .5f, .5f);
                            point3 = new Vector3(-.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        case TriangleOrigin.PMIn:
                            point1 = new Vector3(.5f, .5f, -.5f);
                            point2 = new Vector3(-.5f, .5f, -.5f);
                            point3 = new Vector3(.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        case TriangleOrigin.PPIn:
                            point1 = new Vector3(.5f, .5f, .5f);
                            point2 = new Vector3(.5f, .5f, -.5f);
                            point3 = new Vector3(-.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
                    }
                    break;

                case Direction.Back:
                    switch (triangleOrigin)
                    {
                        case TriangleOrigin.MMOut:
                            point1 = new Vector3(-.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, .5f, -.5f);
                            point3 = new Vector3(.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        case TriangleOrigin.MPOut:
                            point1 = new Vector3(-.5f, .5f, -.5f);
                            point2 = new Vector3(.5f, .5f, -.5f);
                            point3 = new Vector3(-.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        case TriangleOrigin.PMOut:
                            point1 = new Vector3(.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, -.5f);
                            point3 = new Vector3(.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        case TriangleOrigin.PPOut:
                            point1 = new Vector3(.5f, .5f, -.5f);
                            point2 = new Vector3(.5f, 0, -.5f);
                            point3 = new Vector3(-.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;
                        
                        case TriangleOrigin.MMIn:
                            point1 = new Vector3(-.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, .5f, -.5f);
                            point3 = new Vector3(.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        case TriangleOrigin.MPIn:
                            point1 = new Vector3(-.5f, .5f, -.5f);
                            point2 = new Vector3(.5f, .5f, -.5f);
                            point3 = new Vector3(-.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        case TriangleOrigin.PMIn:
                            point1 = new Vector3(.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, -.5f);
                            point3 = new Vector3(.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        case TriangleOrigin.PPIn:
                            point1 = new Vector3(.5f, .5f, -.5f);
                            point2 = new Vector3(.5f, 0, -.5f);
                            point3 = new Vector3(-.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
                    }
                    break;

                case Direction.Front:
                    switch (triangleOrigin)
                    {
                        case TriangleOrigin.MMOut:
                            point1 = new Vector3(-.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, .5f);
                            point3 = new Vector3(-.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        case TriangleOrigin.MPOut:
                            point1 = new Vector3(-.5f, .5f, .5f);
                            point2 = new Vector3(-.5f, 0, .5f);
                            point3 = new Vector3(.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        case TriangleOrigin.PMOut:
                            point1 = new Vector3(.5f, 0, .5f);
                            point2 = new Vector3(.5f, .5f, .5f);
                            point3 = new Vector3(-.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        case TriangleOrigin.PPOut:
                            point1 = new Vector3(.5f, .5f, .5f);
                            point2 = new Vector3(-.5f, .5f, .5f);
                            point3 = new Vector3(.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;
                        
                        case TriangleOrigin.MMIn:
                            point1 = new Vector3(-.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, .5f);
                            point3 = new Vector3(-.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        case TriangleOrigin.MPIn:
                            point1 = new Vector3(-.5f, .5f, .5f);
                            point2 = new Vector3(-.5f, 0, .5f);
                            point3 = new Vector3(.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        case TriangleOrigin.PMIn:
                            point1 = new Vector3(.5f, 0, .5f);
                            point2 = new Vector3(.5f, .5f, .5f);
                            point3 = new Vector3(-.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        case TriangleOrigin.PPIn:
                            point1 = new Vector3(.5f, .5f, .5f);
                            point2 = new Vector3(-.5f, .5f, .5f);
                            point3 = new Vector3(.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
                    }
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }

            var mesh = new Mesh
            {
                vertices = new[]
                {
                    point1,
                    point2,
                    point3
                },
                triangles = triangles,
                uv = new[]
                {
                    uv1,
                    uv2,
                    uv3
                },
                normals = new[]
                {
                    normal1,
                    normal2,
                    normal3
                }
            };

            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();

            return mesh;
        }
        
        /// <summary>
        /// Create a 90° degree triangle with one vertex down at.
        /// </summary>
        /// <returns></returns>
        public static Mesh CreateRectangleTriangleWithOneVertexDown(Direction direction, TriangleOrigin triangleOrigin, byte fromOriginClockwise)
        {
            Vector3 point1;
            Vector3 point2;
            Vector3 point3;

            int[] triangles;
            
            Vector2 uv1;
            Vector2 uv2;
            Vector2 uv3;

            Vector3 normal1;
            Vector3 normal2;
            Vector3 normal3;

            switch (direction)
            {
                case Direction.Left:
                    switch (triangleOrigin)
                    {
                        case TriangleOrigin.MMOut:
                            point1 = new Vector3(-.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, .5f);
                            point3 = new Vector3(-.5f, .5f, -.5f);
                                  
                            triangles = new[]
                            {
                                0,1,2
                            };
                                                              
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                                  
                        case TriangleOrigin.MPOut:
                            point1 = new Vector3(-.5f, 0, .5f);
                            point2 = new Vector3(-.5f, .5f, .5f);
                            point3 = new Vector3(-.5f, 0, -.5f);
                                                              
                            triangles = new[]
                            {
                                0,1,2
                            };
                                                              
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                                  
                        case TriangleOrigin.PMOut:
                            point1 = new Vector3(-.5f, .5f, -.5f);
                            point2 = new Vector3(-.5f, 0, -.5f);
                            point3 = new Vector3(-.5f, .5f, .5f);
                                                              
                            triangles = new[]
                            {
                                0,1,2
                            };
                                                              
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                                  
                        case TriangleOrigin.PPOut:
                            point1 = new Vector3(-.5f, .5f, .5f);
                            point2 = new Vector3(-.5f, .5f, -.5f);
                            point3 = new Vector3(-.5f, 0, .5f);
                                                              
                            triangles = new[]
                            {
                                0,1,2
                            };
                                                              
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                        
                        case TriangleOrigin.MMIn:
                            point1 = new Vector3(-.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, .5f);
                            point3 = new Vector3(-.5f, .5f, -.5f);
                                  
                            triangles = new[]
                            {
                                2,1,0
                            };
                                                              
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                                  
                        case TriangleOrigin.MPIn:
                            point1 = new Vector3(-.5f, 0, .5f);
                            point2 = new Vector3(-.5f, .5f, .5f);
                            point3 = new Vector3(-.5f, 0, -.5f);
                                                              
                            triangles = new[]
                            {
                                2,1,0
                            };
                                                              
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                                  
                        case TriangleOrigin.PMIn:
                            point1 = new Vector3(-.5f, .5f, -.5f);
                            point2 = new Vector3(-.5f, 0, -.5f);
                            point3 = new Vector3(-.5f, .5f, .5f);
                                                              
                            triangles = new[]
                            {
                                2,1,0
                            };
                                                              
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;
                                  
                        case TriangleOrigin.PPIn:
                            point1 = new Vector3(-.5f, .5f, .5f);
                            point2 = new Vector3(-.5f, .5f, -.5f);
                            point3 = new Vector3(-.5f, 0, .5f);
                                                              
                            triangles = new[]
                            {
                                2,1,0
                            };
                                                              
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                                                              
                            normal1 = new Vector3(-.5f,0,0);
                            normal2 = new Vector3(-.5f,0,0);
                            normal3 = new Vector3(-.5f,0,0);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
                    }
                    break;

                case Direction.Right:
                    switch (triangleOrigin)
                    {
                        case TriangleOrigin.MMOut:
                            point1 = new Vector3(.5f, 0, -.5f);
                            point2 = new Vector3(.5f, .5f, -.5f);
                            point3 = new Vector3(.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        case TriangleOrigin.MPOut:
                            point1 = new Vector3(.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, -.5f);
                            point3 = new Vector3(.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        case TriangleOrigin.PMOut:
                            point1 = new Vector3(.5f, .5f, -.5f);
                            point2 = new Vector3(.5f, .5f, .5f);
                            point3 = new Vector3(.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        case TriangleOrigin.PPOut:
                            point1 = new Vector3(.5f, .5f, .5f);
                            point2 = new Vector3(.5f, 0, .5f);
                            point3 = new Vector3(.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;
                        
                        case TriangleOrigin.MMIn:
                            point1 = new Vector3(.5f, 0, -.5f);
                            point2 = new Vector3(.5f, .5f, -.5f);
                            point3 = new Vector3(.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        case TriangleOrigin.MPIn:
                            point1 = new Vector3(.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, -.5f);
                            point3 = new Vector3(.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        case TriangleOrigin.PMIn:
                            point1 = new Vector3(.5f, .5f, -.5f);
                            point2 = new Vector3(.5f, .5f, .5f);
                            point3 = new Vector3(.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        case TriangleOrigin.PPIn:
                            point1 = new Vector3(.5f, .5f, .5f);
                            point2 = new Vector3(.5f, 0, .5f);
                            point3 = new Vector3(.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(.5f,0,0);
                            normal2 = new Vector3(.5f,0,0);
                            normal3 = new Vector3(.5f,0,0);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
                    }
                    break;

                case Direction.Bottom:
                    switch (triangleOrigin)
                    {
                        case TriangleOrigin.MMOut:
                            point1 = new Vector3(-.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, .5f);
                            point3 = new Vector3(.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        case TriangleOrigin.MPOut:
                            point1 = new Vector3(-.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, .5f);
                            point3 = new Vector3(-.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        case TriangleOrigin.PMOut:
                            point1 = new Vector3(.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, -.5f);
                            point3 = new Vector3(.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        case TriangleOrigin.PPOut:
                            point1 = new Vector3(.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, -.5f);
                            point3 = new Vector3(-.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;
                        
                        case TriangleOrigin.MMIn:
                            point1 = new Vector3(-.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, .5f);
                            point3 = new Vector3(.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        case TriangleOrigin.MPIn:
                            point1 = new Vector3(-.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, .5f);
                            point3 = new Vector3(-.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        case TriangleOrigin.PMIn:
                            point1 = new Vector3(.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, -.5f);
                            point3 = new Vector3(.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        case TriangleOrigin.PPIn:
                            point1 = new Vector3(.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, -.5f);
                            point3 = new Vector3(-.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,-.5f,0);
                            normal2 = new Vector3(0,-.5f,0);
                            normal3 = new Vector3(0,-.5f,0);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
                    }
                    break;

                case Direction.Top:
                    switch (triangleOrigin)
                    {
                        case TriangleOrigin.MMOut:
                            point1 = new Vector3(-.5f, .5f, -.5f);
                            point2 = new Vector3(-.5f, .5f, .5f);
                            point3 = new Vector3(.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        case TriangleOrigin.MPOut:
                            point1 = new Vector3(-.5f, .5f, .5f);
                            point2 = new Vector3(.5f, .5f, .5f);
                            point3 = new Vector3(-.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        case TriangleOrigin.PMOut:
                            point1 = new Vector3(.5f, .5f, -.5f);
                            point2 = new Vector3(-.5f, .5f, -.5f);
                            point3 = new Vector3(.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        case TriangleOrigin.PPOut:
                            point1 = new Vector3(.5f, .5f, .5f);
                            point2 = new Vector3(.5f, .5f, -.5f);
                            point3 = new Vector3(-.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;
                        
                        case TriangleOrigin.MMIn:
                            point1 = new Vector3(-.5f, .5f, -.5f);
                            point2 = new Vector3(-.5f, .5f, .5f);
                            point3 = new Vector3(.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        case TriangleOrigin.MPIn:
                            point1 = new Vector3(-.5f, .5f, .5f);
                            point2 = new Vector3(.5f, .5f, .5f);
                            point3 = new Vector3(-.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        case TriangleOrigin.PMIn:
                            point1 = new Vector3(.5f, .5f, -.5f);
                            point2 = new Vector3(-.5f, .5f, -.5f);
                            point3 = new Vector3(.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        case TriangleOrigin.PPIn:
                            point1 = new Vector3(.5f, .5f, .5f);
                            point2 = new Vector3(.5f, .5f, -.5f);
                            point3 = new Vector3(-.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,.5f,0);
                            normal2 = new Vector3(0,.5f,0);
                            normal3 = new Vector3(0,.5f,0);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
                    }
                    break;

                case Direction.Back:
                    switch (triangleOrigin)
                    {
                        case TriangleOrigin.MMOut:
                            point1 = new Vector3(-.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, .5f, -.5f);
                            point3 = new Vector3(.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        case TriangleOrigin.MPOut:
                            point1 = new Vector3(-.5f, .5f, -.5f);
                            point2 = new Vector3(.5f, .5f, -.5f);
                            point3 = new Vector3(-.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        case TriangleOrigin.PMOut:
                            point1 = new Vector3(.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, -.5f);
                            point3 = new Vector3(.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        case TriangleOrigin.PPOut:
                            point1 = new Vector3(.5f, .5f, -.5f);
                            point2 = new Vector3(.5f, 0, -.5f);
                            point3 = new Vector3(-.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;
                        
                        case TriangleOrigin.MMIn:
                            point1 = new Vector3(-.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, .5f, -.5f);
                            point3 = new Vector3(.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        case TriangleOrigin.MPIn:
                            point1 = new Vector3(-.5f, .5f, -.5f);
                            point2 = new Vector3(.5f, .5f, -.5f);
                            point3 = new Vector3(-.5f, 0, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        case TriangleOrigin.PMIn:
                            point1 = new Vector3(.5f, 0, -.5f);
                            point2 = new Vector3(-.5f, 0, -.5f);
                            point3 = new Vector3(.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        case TriangleOrigin.PPIn:
                            point1 = new Vector3(.5f, .5f, -.5f);
                            point2 = new Vector3(.5f, 0, -.5f);
                            point3 = new Vector3(-.5f, .5f, -.5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,0,-.5f);
                            normal2 = new Vector3(0,0,-.5f);
                            normal3 = new Vector3(0,0,-.5f);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
                    }
                    break;

                case Direction.Front:
                    switch (triangleOrigin)
                    {
                        case TriangleOrigin.MMOut:
                            point1 = new Vector3(-.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, .5f);
                            point3 = new Vector3(-.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        case TriangleOrigin.MPOut:
                            point1 = new Vector3(-.5f, .5f, .5f);
                            point2 = new Vector3(-.5f, 0, .5f);
                            point3 = new Vector3(.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        case TriangleOrigin.PMOut:
                            point1 = new Vector3(.5f, 0, .5f);
                            point2 = new Vector3(.5f, .5f, .5f);
                            point3 = new Vector3(-.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        case TriangleOrigin.PPOut:
                            point1 = new Vector3(.5f, .5f, .5f);
                            point2 = new Vector3(-.5f, .5f, .5f);
                            point3 = new Vector3(.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                0,1,2
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;
                        
                        case TriangleOrigin.MMIn:
                            point1 = new Vector3(-.5f, 0, .5f);
                            point2 = new Vector3(.5f, 0, .5f);
                            point3 = new Vector3(-.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,0);
                            uv2 = new Vector2(0,0);
                            uv3 = new Vector2(1,1);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        case TriangleOrigin.MPIn:
                            point1 = new Vector3(-.5f, .5f, .5f);
                            point2 = new Vector3(-.5f, 0, .5f);
                            point3 = new Vector3(.5f, .5f, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(1,1);
                            uv2 = new Vector2(1,0);
                            uv3 = new Vector2(0,1);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        case TriangleOrigin.PMIn:
                            point1 = new Vector3(.5f, 0, .5f);
                            point2 = new Vector3(.5f, .5f, .5f);
                            point3 = new Vector3(-.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,0);
                            uv2 = new Vector2(0,1);
                            uv3 = new Vector2(1,0);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        case TriangleOrigin.PPIn:
                            point1 = new Vector3(.5f, .5f, .5f);
                            point2 = new Vector3(-.5f, .5f, .5f);
                            point3 = new Vector3(.5f, 0, .5f);
                            
                            triangles = new[]
                            {
                                2,1,0
                            };
                            
                            uv1 = new Vector2(0,1);
                            uv2 = new Vector2(1,1);
                            uv3 = new Vector2(0,0);
                            
                            normal1 = new Vector3(0,0,.5f);
                            normal2 = new Vector3(0,0,.5f);
                            normal3 = new Vector3(0,0,.5f);
                            break;

                        default:
                            throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
                    }
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }

            var mesh = new Mesh
            {
                vertices = new[]
                {
                    point1,
                    point2,
                    point3
                },
                triangles = triangles,
                uv = new[]
                {
                    uv1,
                    uv2,
                    uv3
                },
                normals = new[]
                {
                    normal1,
                    normal2,
                    normal3
                }
            };

            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();

            return mesh;
        }
        
        
        
        
        
        
        
        /// <summary>
        /// Create a triangle pointing down.
        /// </summary>
        /// <returns></returns>
        public static Mesh CreateTrianglePointingDown(TriangleOrigin triangleOrigin)
        {
            Vector3 point1;
            Vector3 point2;
            Vector3 point3;

            int[] triangles;
            
            Vector2 uv1;
            Vector2 uv2;
            Vector2 uv3;

            Vector3 normal1;
            Vector3 normal2;
            Vector3 normal3;

            switch (triangleOrigin)
            {
                case TriangleOrigin.MMOut:
                    point1 = new Vector3(-.5f, 0, -.5f);
                    point2 = new Vector3(-.5f, .5f, .5f);
                    point3 = new Vector3(.5f, .5f, -.5f);

                    triangles = new[]
                    {
                        0,1,2
                    };
                            
                    uv1 = new Vector2(0,0);
                    uv2 = new Vector2(0,1);
                    uv3 = new Vector2(1,0);
                            
                    normal1 = new Vector3(-.5f,-.5f,-.5f);
                    normal2 = new Vector3(-.5f,-.5f,-.5f);
                    normal3 = new Vector3(-.5f,-.5f,-.5f);
                    break;

                case TriangleOrigin.MPOut:
                    point1 = new Vector3(-.5f, 0, .5f);
                    point2 = new Vector3(.5f, .5f, .5f);
                    point3 = new Vector3(-.5f, .5f, -.5f);
                            
                    triangles = new[]
                    {
                        0,1,2
                    };
                            
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(0,0);
                            
                    normal1 = new Vector3(-.5f,.5f,.5f);
                    normal2 = new Vector3(-.5f,.5f,.5f);
                    normal3 = new Vector3(-.5f,.5f,.5f);
                    break;

                case TriangleOrigin.PMOut:
                    point1 = new Vector3(.5f, 0, -.5f);
                    point2 = new Vector3(-.5f, .5f, -.5f);
                    point3 = new Vector3(.5f, .5f, .5f);
                            
                    triangles = new[]
                    {
                        0,1,2
                    };
                            
                    uv1 = new Vector2(1,0);
                    uv2 = new Vector2(0,0);
                    uv3 = new Vector2(1,1);
                            
                    normal1 = new Vector3(.5f,.5f,-.5f);
                    normal2 = new Vector3(.5f,.5f,-.5f);
                    normal3 = new Vector3(.5f,.5f,-.5f);
                    break;

                case TriangleOrigin.PPOut:
                    point1 = new Vector3(.5f, 0, .5f);
                    point2 = new Vector3(.5f, .5f, -.5f);
                    point3 = new Vector3(-.5f, .5f, .5f);
                            
                    triangles = new[]
                    {
                        0,1,2
                    };
                            
                    uv1 = new Vector2(1,1);
                    uv2 = new Vector2(1,0);
                    uv3 = new Vector2(0,1);
                            
                    normal1 = new Vector3(.5f,.5f,.5f);
                    normal2 = new Vector3(.5f,.5f,.5f);
                    normal3 = new Vector3(.5f,.5f,.5f);
                    break;
                
                case TriangleOrigin.MMIn:
                    point1 = new Vector3(-.5f, 0, -.5f);
                    point2 = new Vector3(-.5f, .5f, .5f);
                    point3 = new Vector3(.5f, .5f, -.5f);

                    triangles = new[]
                    {
                        2,1,0
                    };
                            
                    uv1 = new Vector2(0,0);
                    uv2 = new Vector2(0,1);
                    uv3 = new Vector2(1,0);
                            
                    normal1 = new Vector3(-.5f,-.5f,-.5f);
                    normal2 = new Vector3(-.5f,-.5f,-.5f);
                    normal3 = new Vector3(-.5f,-.5f,-.5f);
                    break;

                case TriangleOrigin.MPIn:
                    point1 = new Vector3(-.5f, 0, .5f);
                    point2 = new Vector3(.5f, .5f, .5f);
                    point3 = new Vector3(-.5f, .5f, -.5f);
                            
                    triangles = new[]
                    {
                        2,1,0
                    };
                            
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(0,0);
                            
                    normal1 = new Vector3(-.5f,.5f,.5f);
                    normal2 = new Vector3(-.5f,.5f,.5f);
                    normal3 = new Vector3(-.5f,.5f,.5f);
                    break;

                case TriangleOrigin.PMIn:
                    point1 = new Vector3(.5f, 0, -.5f);
                    point2 = new Vector3(-.5f, .5f, -.5f);
                    point3 = new Vector3(.5f, .5f, .5f);
                            
                    triangles = new[]
                    {
                        2,1,0
                    };
                            
                    uv1 = new Vector2(1,0);
                    uv2 = new Vector2(0,0);
                    uv3 = new Vector2(1,1);
                            
                    normal1 = new Vector3(.5f,.5f,-.5f);
                    normal2 = new Vector3(.5f,.5f,-.5f);
                    normal3 = new Vector3(.5f,.5f,-.5f);
                    break;

                case TriangleOrigin.PPIn:
                    point1 = new Vector3(.5f, 0, .5f);
                    point2 = new Vector3(.5f, .5f, -.5f);
                    point3 = new Vector3(-.5f, .5f, .5f);
                            
                    triangles = new[]
                    {
                        2,1,0
                    };
                            
                    uv1 = new Vector2(1,1);
                    uv2 = new Vector2(1,0);
                    uv3 = new Vector2(0,1);
                            
                    normal1 = new Vector3(.5f,.5f,.5f);
                    normal2 = new Vector3(.5f,.5f,.5f);
                    normal3 = new Vector3(.5f,.5f,.5f);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
            }

            var mesh = new Mesh
            {
                vertices = new[]
                {
                    point1,
                    point2,
                    point3
                },
                triangles = triangles,
                uv = new[]
                {
                    uv1,
                    uv2,
                    uv3
                },
                normals = new[]
                {
                    normal1,
                    normal2,
                    normal3
                }
            };

            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();

            return mesh;
        }
        
        /// <summary>
        /// Create a triangle pointing up.
        /// </summary>
        /// <returns></returns>
        public static Mesh CreateTrianglePointingUp(TriangleOrigin triangleOrigin)
        {
            Vector3 point1;
            Vector3 point2;
            Vector3 point3;

            int[] triangles;
            
            Vector2 uv1;
            Vector2 uv2;
            Vector2 uv3;

            Vector3 normal1;
            Vector3 normal2;
            Vector3 normal3;

            switch (triangleOrigin)
            {
                case TriangleOrigin.MMOut:
                    point1 = new Vector3(-.5f, .5f, -.5f);
                    point2 = new Vector3(-.5f, 0, .5f);
                    point3 = new Vector3(.5f, 0, -.5f);

                    triangles = new[]
                    {
                        0,1,2
                    };
                            
                    uv1 = new Vector2(0,0);
                    uv2 = new Vector2(0,1);
                    uv3 = new Vector2(1,0);
                            
                    normal1 = new Vector3(.5f,.5f,.5f);
                    normal2 = new Vector3(.5f,.5f,.5f);
                    normal3 = new Vector3(.5f,.5f,.5f);
                    break;

                case TriangleOrigin.MPOut:
                    point1 = new Vector3(-.5f, .5f, .5f);
                    point2 = new Vector3(.5f, 0, .5f);
                    point3 = new Vector3(-.5f, 0, -.5f);
                            
                    triangles = new[]
                    {
                        0,1,2
                    };
                            
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(0,0);
                            
                    normal1 = new Vector3(.5f,.5f,-.5f);
                    normal2 = new Vector3(.5f,.5f,-.5f);
                    normal3 = new Vector3(.5f,.5f,-.5f);
                    break;

                case TriangleOrigin.PMOut:
                    point1 = new Vector3(.5f, .5f, -.5f);
                    point2 = new Vector3(-.5f, 0, -.5f);
                    point3 = new Vector3(.5f, 0, .5f);
                            
                    triangles = new[]
                    {
                        0,1,2
                    };
                            
                    uv1 = new Vector2(1,0);
                    uv2 = new Vector2(0,0);
                    uv3 = new Vector2(1,1);
                            
                    normal1 = new Vector3(-.5f,.5f,.5f);
                    normal2 = new Vector3(-.5f,.5f,.5f);
                    normal3 = new Vector3(-.5f,.5f,.5f);
                    break;

                case TriangleOrigin.PPOut:
                    point1 = new Vector3(.5f, .5f, .5f);
                    point2 = new Vector3(.5f, 0, -.5f);
                    point3 = new Vector3(-.5f, 0, .5f);
                            
                    triangles = new[]
                    {
                        0,1,2
                    };
                            
                    uv1 = new Vector2(1,1);
                    uv2 = new Vector2(1,0);
                    uv3 = new Vector2(0,1);
                            
                    normal1 = new Vector3(-.5f,.5f,-.5f);
                    normal2 = new Vector3(-.5f,.5f,-.5f);
                    normal3 = new Vector3(-.5f,.5f,-.5f);
                    break;
                
                case TriangleOrigin.MMIn:
                    point1 = new Vector3(-.5f, .5f, -.5f);
                    point2 = new Vector3(-.5f, 0, .5f);
                    point3 = new Vector3(.5f, 0, -.5f);

                    triangles = new[]
                    {
                        2,1,0
                    };
                            
                    uv1 = new Vector2(0,0);
                    uv2 = new Vector2(0,1);
                    uv3 = new Vector2(1,0);
                            
                    normal1 = new Vector3(.5f,.5f,.5f);
                    normal2 = new Vector3(.5f,.5f,.5f);
                    normal3 = new Vector3(.5f,.5f,.5f);
                    break;

                case TriangleOrigin.MPIn:
                    point1 = new Vector3(-.5f, .5f, .5f);
                    point2 = new Vector3(.5f, 0, .5f);
                    point3 = new Vector3(-.5f, 0, -.5f);
                            
                    triangles = new[]
                    {
                        2,1,0
                    };
                            
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(0,0);
                            
                    normal1 = new Vector3(.5f,.5f,-.5f);
                    normal2 = new Vector3(.5f,.5f,-.5f);
                    normal3 = new Vector3(.5f,.5f,-.5f);
                    break;

                case TriangleOrigin.PMIn:
                    point1 = new Vector3(.5f, .5f, -.5f);
                    point2 = new Vector3(-.5f, 0, -.5f);
                    point3 = new Vector3(.5f, 0, .5f);
                            
                    triangles = new[]
                    {
                        2,1,0
                    };
                            
                    uv1 = new Vector2(1,0);
                    uv2 = new Vector2(0,0);
                    uv3 = new Vector2(1,1);
                            
                    normal1 = new Vector3(-.5f,.5f,.5f);
                    normal2 = new Vector3(-.5f,.5f,.5f);
                    normal3 = new Vector3(-.5f,.5f,.5f);
                    break;

                case TriangleOrigin.PPIn:
                    point1 = new Vector3(.5f, .5f, .5f);
                    point2 = new Vector3(.5f, 0, -.5f);
                    point3 = new Vector3(-.5f, 0, .5f);
                            
                    triangles = new[]
                    {
                        2,1,0
                    };
                            
                    uv1 = new Vector2(1,1);
                    uv2 = new Vector2(1,0);
                    uv3 = new Vector2(0,1);
                            
                    normal1 = new Vector3(-.5f,.5f,-.5f);
                    normal2 = new Vector3(-.5f,.5f,-.5f);
                    normal3 = new Vector3(-.5f,.5f,-.5f);
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(triangleOrigin), triangleOrigin, null);
            }

            var mesh = new Mesh
            {
                vertices = new[]
                {
                    point1,
                    point2,
                    point3
                },
                triangles = triangles,
                uv = new[]
                {
                    uv1,
                    uv2,
                    uv3
                },
                normals = new[]
                {
                    normal1,
                    normal2,
                    normal3
                }
            };

            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();

            return mesh;
        }

        /// <summary>
        /// Create a ramp.
        /// </summary>
        /// <param name="rampDirection"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Mesh CreateRamp(RampDirection rampDirection)
        {
            Vector3 point1;
            Vector3 point2;
            Vector3 point3;
            Vector3 point4;

            int[] triangles;
            
            Vector2 uv1;
            Vector2 uv2;
            Vector2 uv3;
            Vector2 uv4;

            Vector3 normal1;
            Vector3 normal2;
            Vector3 normal3;
            Vector3 normal4;
            
            switch (rampDirection)
            {
                case RampDirection.LeftTop:
                    point1 = new Vector3(-.5f, .5f, .5f);
                    point2 = new Vector3(.5f, 0, .5f);
                    point3 = new Vector3(.5f, 0, -.5f);
                    point4 = new Vector3(-.5f, .5f, -.5f);

                    triangles = new[]
                    {
                        0,1,2,
                        0,2,3
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(.5f,.5f,0);
                    normal2 = new Vector3(.5f,.5f,0);
                    normal3 = new Vector3(.5f,.5f,0);
                    normal4 = new Vector3(.5f,.5f,0);
                    break;
                
                case RampDirection.RightTop:
                    point1 = new Vector3(-.5f, 0, .5f);
                    point2 = new Vector3(.5f, .5f, .5f);
                    point3 = new Vector3(.5f, .5f, -.5f);
                    point4 = new Vector3(-.5f, 0, -.5f);

                    triangles = new[]
                    {
                        0,1,2,
                        0,2,3
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(-.5f,.5f,0);
                    normal2 = new Vector3(-.5f,.5f,0);
                    normal3 = new Vector3(-.5f,.5f,0);
                    normal4 = new Vector3(-.5f,.5f,0);
                    break;
                
                case RampDirection.BackTop:
                    point1 = new Vector3(-.5f, 0, .5f);
                    point2 = new Vector3(.5f, 0, .5f);
                    point3 = new Vector3(.5f, .5f, -.5f);
                    point4 = new Vector3(-.5f, .5f, -.5f);

                    triangles = new[]
                    {
                        0,1,2,
                        0,2,3
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(0,.5f,.5f);
                    normal2 = new Vector3(0,.5f,.5f);
                    normal3 = new Vector3(0,.5f,.5f);
                    normal4 = new Vector3(0,.5f,.5f);
                    break;
                
                case RampDirection.FrontTop:
                    point1 = new Vector3(-.5f, .5f, .5f);
                    point2 = new Vector3(.5f, .5f, .5f);
                    point3 = new Vector3(.5f, 0, -.5f);
                    point4 = new Vector3(-.5f, 0, -.5f);

                    triangles = new[]
                    {
                        0,1,2,
                        0,2,3
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(0,.5f,-.5f);
                    normal2 = new Vector3(0,.5f,-.5f);
                    normal3 = new Vector3(0,.5f,-.5f);
                    normal4 = new Vector3(0,.5f,-.5f);
                    break;
                
                case RampDirection.LeftBottom:
                    point1 = new Vector3(-.5f, .5f, .5f);
                    point2 = new Vector3(.5f, 0, .5f);
                    point3 = new Vector3(.5f, 0, -.5f);
                    point4 = new Vector3(-.5f, .5f, -.5f);

                    triangles = new[]
                    {
                        2,1,0,
                        3,2,0
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(-.5f,-.5f,0);
                    normal2 = new Vector3(-.5f,-.5f,0);
                    normal3 = new Vector3(-.5f,-.5f,0);
                    normal4 = new Vector3(-.5f,-.5f,0);
                    break;
                
                case RampDirection.RightBottom:
                    point1 = new Vector3(-.5f, 0, .5f);
                    point2 = new Vector3(.5f, .5f, .5f);
                    point3 = new Vector3(.5f, .5f, -.5f);
                    point4 = new Vector3(-.5f, 0, -.5f);

                    triangles = new[]
                    {
                        2,1,0,
                        3,2,0
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(.5f,-.5f,0);
                    normal2 = new Vector3(.5f,-.5f,0);
                    normal3 = new Vector3(.5f,-.5f,0);
                    normal4 = new Vector3(.5f,-.5f,0);
                    break;
                
                case RampDirection.BackBottom:
                    point1 = new Vector3(-.5f, 0, .5f);
                    point2 = new Vector3(.5f, 0, .5f);
                    point3 = new Vector3(.5f, .5f, -.5f);
                    point4 = new Vector3(-.5f, .5f, -.5f);

                    triangles = new[]
                    {
                        2,1,0,
                        3,2,0
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(0,-.5f,-.5f);
                    normal2 = new Vector3(0,-.5f,-.5f);
                    normal3 = new Vector3(0,-.5f,-.5f);
                    normal4 = new Vector3(0,-.5f,-.5f);
                    break;
                
                case RampDirection.FrontBottom:
                    point1 = new Vector3(-.5f, .5f, .5f);
                    point2 = new Vector3(.5f, .5f, .5f);
                    point3 = new Vector3(.5f, 0, -.5f);
                    point4 = new Vector3(-.5f, 0, -.5f);

                    triangles = new[]
                    {
                        2,1,0,
                        3,2,0
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(0,-.5f,.5f);
                    normal2 = new Vector3(0,-.5f,.5f);
                    normal3 = new Vector3(0,-.5f,.5f);
                    normal4 = new Vector3(0,-.5f,.5f);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(rampDirection), rampDirection, null);
            }
            
            var mesh = new Mesh
            {
                vertices = new[]
                {
                    point1,
                    point2,
                    point3,
                    point4
                },
                triangles = triangles,
                uv = new[]
                {
                    uv1,
                    uv2,
                    uv3,
                    uv4
                },
                normals = new[]
                {
                    normal1,
                    normal2,
                    normal3,
                    normal4
                }
            };

            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();

            return mesh;
        }
        
        public static Mesh CreateRampWithOneUpVertexDown(RampDirection rampDirection, bool positiveSide)
        {
            Vector3 point1;
            Vector3 point2;
            Vector3 point3;
            Vector3 point4;

            int[] triangles;

            Vector2 uv1;
            Vector2 uv2;
            Vector2 uv3;
            Vector2 uv4;

            Vector3 normal1;
            Vector3 normal2;
            Vector3 normal3;
            Vector3 normal4;
            
            switch (rampDirection)
            {
                case RampDirection.LeftTop:
                    if (positiveSide)
                    {
                        point1 = new Vector3(-.5f, 0, .5f);
                        point2 = new Vector3(.5f, 0, .5f);
                        point3 = new Vector3(.5f, 0, -.5f);
                        point4 = new Vector3(-.5f, .5f, -.5f);
                    }
                    else
                    {
                        point1 = new Vector3(-.5f, 0.5f, .5f);
                        point2 = new Vector3(.5f, 0, .5f);
                        point3 = new Vector3(.5f, 0, -.5f);
                        point4 = new Vector3(-.5f, 0, -.5f);
                    }
                    
                    triangles = new[]
                    {
                        0,1,2,
                        0,2,3
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(.5f,.5f,0);
                    normal2 = new Vector3(.5f,.5f,0);
                    normal3 = new Vector3(.5f,.5f,0);
                    normal4 = new Vector3(.5f,.5f,0);
                    break;
                
                case RampDirection.RightTop:
                    if (positiveSide)
                    {
                        point1 = new Vector3(-.5f, 0, .5f);
                        point2 = new Vector3(.5f, 0, .5f);
                        point3 = new Vector3(.5f, .5f, -.5f);
                        point4 = new Vector3(-.5f, 0, -.5f);
                    }
                    else
                    {
                        point1 = new Vector3(-.5f, 0, .5f);
                        point2 = new Vector3(.5f, 0.5f, .5f);
                        point3 = new Vector3(.5f, 0, -.5f);
                        point4 = new Vector3(-.5f, 0, -.5f);
                    }

                    triangles = new[]
                    {
                        0,1,2,
                        0,2,3
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(-.5f,.5f,0);
                    normal2 = new Vector3(-.5f,.5f,0);
                    normal3 = new Vector3(-.5f,.5f,0);
                    normal4 = new Vector3(-.5f,.5f,0);
                    break;
                
                case RampDirection.BackTop:
                    if (positiveSide)
                    {
                        point1 = new Vector3(-.5f, 0,.5f);
                        point2 = new Vector3(.5f,0,.5f);
                        point3 = new Vector3(.5f,0,-.5f);
                        point4 = new Vector3(-.5f,.5f,-.5f);
                    }
                    else
                    {
                        point1 = new Vector3(-.5f, 0,.5f);
                        point2 = new Vector3(.5f,0,.5f);
                        point3 = new Vector3(.5f,.5f,-.5f);
                        point4 = new Vector3(-.5f,0,-.5f);
                    }

                    triangles = new[]
                    {
                        0,1,2,
                        0,2,3
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(0,.5f,.5f);
                    normal2 = new Vector3(0,.5f,.5f);
                    normal3 = new Vector3(0,.5f,.5f);
                    normal4 = new Vector3(0,.5f,.5f);
                    break;
                
                case RampDirection.FrontTop:
                    if (positiveSide)
                    {
                        point1 = new Vector3(-.5f, .5f, .5f);
                        point2 = new Vector3(.5f, 0, .5f);
                        point3 = new Vector3(.5f, 0, -.5f);
                        point4 = new Vector3(-.5f, 0, -.5f);
                    }
                    else
                    {
                        point1 = new Vector3(-.5f, 0, .5f);
                        point2 = new Vector3(.5f, 0.5f, .5f);
                        point3 = new Vector3(.5f, 0, -.5f);
                        point4 = new Vector3(-.5f, 0, -.5f);
                    }
                    
                    triangles = new[]
                    {
                        0,1,3,
                        1,2,3
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(0,.5f,-.5f);
                    normal2 = new Vector3(0,.5f,-.5f);
                    normal3 = new Vector3(0,.5f,-.5f);
                    normal4 = new Vector3(0,.5f,-.5f);
                    break;
                
                case RampDirection.LeftBottom:
                    point1 = new Vector3(-.5f, positiveSide ? 0: 0.5f, .5f);
                    point2 = new Vector3(.5f, 0, .5f);
                    point3 = new Vector3(.5f, 0, -.5f);
                    point4 = new Vector3(-.5f, positiveSide ? 0.5f: 0, -.5f);

                    triangles = new[]
                    {
                        3,1,0,
                        3,2,1
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(-.5f,-.5f,0);
                    normal2 = new Vector3(-.5f,-.5f,0);
                    normal3 = new Vector3(-.5f,-.5f,0);
                    normal4 = new Vector3(-.5f,-.5f,0);
                    break;
                
                case RampDirection.RightBottom:
                    point1 = new Vector3(-.5f, 0, .5f);
                    point2 = new Vector3(.5f, positiveSide ? .5f: 0, .5f);
                    point3 = new Vector3(.5f, positiveSide ? 0.5f: 0, -.5f);
                    point4 = new Vector3(-.5f, 0, -.5f);

                    triangles = new[]
                    {
                        3,1,0,
                        3,2,1
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(.5f,-.5f,0);
                    normal2 = new Vector3(.5f,-.5f,0);
                    normal3 = new Vector3(.5f,-.5f,0);
                    normal4 = new Vector3(.5f,-.5f,0);
                    break;
                
                case RampDirection.BackBottom:
                    point1 = new Vector3(-.5f, 0, .5f);
                    point2 = new Vector3(.5f, 0, .5f);
                    point3 = new Vector3(.5f, positiveSide ? 0: 0.5f, -.5f);
                    point4 = new Vector3(-.5f, positiveSide ? 0.5f: 0, -.5f);

                    triangles = new[]
                    {
                        3,1,0,
                        3,2,1
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(0,-.5f,-.5f);
                    normal2 = new Vector3(0,-.5f,-.5f);
                    normal3 = new Vector3(0,-.5f,-.5f);
                    normal4 = new Vector3(0,-.5f,-.5f);
                    break;
                
                case RampDirection.FrontBottom:
                    point1 = new Vector3(-.5f, positiveSide ? 0.5f: 0, .5f);
                    point2 = new Vector3(.5f, positiveSide ? 0: 0.5f, .5f);
                    point3 = new Vector3(.5f, 0, -.5f);
                    point4 = new Vector3(-.5f, 0, -.5f);

                    triangles = new[]
                    {
                        3,1,0,
                        3,2,1
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(0,-.5f,.5f);
                    normal2 = new Vector3(0,-.5f,.5f);
                    normal3 = new Vector3(0,-.5f,.5f);
                    normal4 = new Vector3(0,-.5f,.5f);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(rampDirection), rampDirection, null);
            }
            
            var mesh = new Mesh
            {
                vertices = new[]
                {
                    point1,
                    point2,
                    point3,
                    point4
                },
                triangles = triangles,
                uv = new[]
                {
                    uv1,
                    uv2,
                    uv3,
                    uv4
                },
                normals = new[]
                {
                    normal1,
                    normal2,
                    normal3,
                    normal4
                }
            };

            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();

            return mesh;
        }
        
        /// <summary>
        /// Diagonal half quad.
        /// </summary>
        /// <param name="diagonalQuadDirection"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Mesh CreateDiagonalQuad(DiagonalQuadDirection diagonalQuadDirection)
        {
            Vector3 point1;
            Vector3 point2;
            Vector3 point3;
            Vector3 point4;

            int[] triangles;
            
            Vector2 uv1;
            Vector2 uv2;
            Vector2 uv3;
            Vector2 uv4;

            Vector3 normal1;
            Vector3 normal2;
            Vector3 normal3;
            Vector3 normal4;
            
            switch (diagonalQuadDirection)
            {
                case DiagonalQuadDirection.LeftBack:
                    point1 = new Vector3(-.5f,0,.5f);
                    point2 = new Vector3(.5f,0,-.5f);
                    point3 = new Vector3(-.5f,.5f,.5f);
                    point4 = new Vector3(.5f,.5f,-.5f);

                    triangles = new[]
                    {
                        0, 2, 3,
                        0, 3, 1
                    };
                    
                    uv1 = new Vector2(0,0);
                    uv2 = new Vector2(1,0);
                    uv3 = new Vector2(0,.5f);
                    uv4 = new Vector2(1,.5f);
                    
                    normal1 = new Vector3(-.5f,0,-.5f);
                    normal2 = new Vector3(-.5f,0,-.5f);
                    normal3 = new Vector3(-.5f,0,-.5f);
                    normal4 = new Vector3(-.5f,0,-.5f);
                    break;
                
                case DiagonalQuadDirection.RightBack:
                    point1 = new Vector3(.5f,0,.5f);
                    point2 = new Vector3(-.5f,0,-.5f);
                    point3 = new Vector3(.5f,.5f,.5f);
                    point4 = new Vector3(-.5f,.5f,-.5f);

                    triangles = new[]
                    {
                        3, 2, 0,
                        1, 3, 0
                    };
                    
                    uv1 = new Vector2(1,0);
                    uv2 = new Vector2(0,0);
                    uv3 = new Vector2(1,.5f);
                    uv4 = new Vector2(0,.5f);
                    
                    normal1 = new Vector3(.5f,0,.5f);
                    normal2 = new Vector3(.5f,0,.5f);
                    normal3 = new Vector3(.5f,0,.5f);
                    normal4 = new Vector3(.5f,0,.5f);
                    break;
                
                case DiagonalQuadDirection.LeftFront:
                    point1 = new Vector3(.5f,0,.5f);
                    point2 = new Vector3(-.5f,0,-.5f);
                    point3 = new Vector3(.5f,.5f,.5f);
                    point4 = new Vector3(-.5f,.5f,-.5f);

                    triangles = new[]
                    {
                        0, 2, 3,
                        0, 3, 1
                    };
                    
                    uv1 = new Vector2(0,0);
                    uv2 = new Vector2(1,0);
                    uv3 = new Vector2(0,.5f);
                    uv4 = new Vector2(1,.5f);
                    
                    normal1 = new Vector3(-.5f,0, .5f);
                    normal2 = new Vector3(-.5f,0, .5f);
                    normal3 = new Vector3(-.5f,0, .5f);
                    normal4 = new Vector3(-.5f,0, .5f);
                    break;
                
                case DiagonalQuadDirection.RightFront:
                    point1 = new Vector3(-.5f,0,.5f);
                    point2 = new Vector3(.5f,0,-.5f);
                    point3 = new Vector3(-.5f,.5f,.5f);
                    point4 = new Vector3(.5f,.5f,-.5f);

                    triangles = new[]
                    {
                        3, 2, 0,
                        1, 3, 0
                    };
                    
                    uv1 = new Vector2(1,0);
                    uv2 = new Vector2(0,0);
                    uv3 = new Vector2(1,.5f);
                    uv4 = new Vector2(0,.5f);
                    
                    normal1 = new Vector3(.5f,0,.5f);
                    normal2 = new Vector3(.5f,0,.5f);
                    normal3 = new Vector3(.5f,0,.5f);
                    normal4 = new Vector3(.5f,0,.5f);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(diagonalQuadDirection), diagonalQuadDirection, null);
            }
            
            var mesh = new Mesh
            {
                vertices = new[]
                {
                    point1,
                    point2,
                    point3,
                    point4
                },
                triangles = triangles,
                uv = new[]
                {
                    uv1,
                    uv2,
                    uv3,
                    uv4
                },
                normals = new[]
                {
                    normal1,
                    normal2,
                    normal3,
                    normal4
                }
            };

            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();

            return mesh;
        }

        /// <summary>
        /// Create half quad.
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static Mesh CreateQuad(Direction direction)
        {
            Vector3 point1;
            Vector3 point2;
            Vector3 point3;
            Vector3 point4;

            int[] triangles;
            
            Vector2 uv1;
            Vector2 uv2;
            Vector2 uv3;
            Vector2 uv4;

            Vector3 normal1;
            Vector3 normal2;
            Vector3 normal3;
            Vector3 normal4;

            switch (direction)
            {
                case Direction.Left:
                    point1 = new Vector3(-.5f,0,.5f);
                    point2 = new Vector3(-.5f,0,-.5f);
                    point3 = new Vector3(-.5f,.5f,.5f);
                    point4 = new Vector3(-.5f,.5f,-.5f);

                    triangles = new[]
                    {
                        0, 2, 3,
                        0, 3, 1
                    };
                    
                    uv1 = new Vector2(0,0);
                    uv2 = new Vector2(1,0);
                    uv3 = new Vector2(0,1);
                    uv4 = new Vector2(1,1);
                    
                    normal1 = new Vector3(-.5f,0,0);
                    normal2 = new Vector3(-.5f,0,0);
                    normal3 = new Vector3(-.5f,0,0);
                    normal4 = new Vector3(-.5f,0,0);
                    break;
                
                case Direction.Right:
                    point1 = new Vector3(.5f,0,.5f);
                    point2 = new Vector3(.5f,0,-.5f);
                    point3 = new Vector3(.5f,.5f,.5f);
                    point4 = new Vector3(.5f,.5f,-.5f);

                    triangles = new[]
                    {
                        0, 1, 3,
                        0, 3, 2
                    };
                    
                    uv1 = new Vector2(1,0);
                    uv2 = new Vector2(0,0);
                    uv3 = new Vector2(1,1);
                    uv4 = new Vector2(0,1);
                    
                    normal1 = new Vector3(.5f,0,0);
                    normal2 = new Vector3(.5f,0,0);
                    normal3 = new Vector3(.5f,0,0);
                    normal4 = new Vector3(.5f,0,0);
                    break;
                
                case Direction.Bottom:
                    point1 = new Vector3(-.5f, 0, .5f);
                    point2 = new Vector3(.5f, 0, .5f);
                    point3= new Vector3(.5f, 0, -.5f);
                    point4 = new Vector3(-.5f, 0, -.5f);
                    
                    triangles = new[]
                    {
                        2,1,0,
                        3,2,0
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(0,-.5f,0);
                    normal2 = new Vector3(0,-.5f,0);
                    normal3 = new Vector3(0,-.5f,0);
                    normal4 = new Vector3(0,-.5f,0);
                    break;
                
                case Direction.Top:
                    point1 = new Vector3(-.5f, .5f, .5f);
                    point2 = new Vector3(.5f, .5f, .5f);
                    point3 = new Vector3(.5f, .5f, -.5f);
                    point4 = new Vector3(-.5f, .5f, -.5f);
                    
                    triangles = new[]
                    {
                        0,1,2,
                        0,2,3
                    };
                    
                    uv1 = new Vector2(0,1);
                    uv2 = new Vector2(1,1);
                    uv3 = new Vector2(1,0);
                    uv4 = new Vector2(0,0);
                    
                    normal1 = new Vector3(0,.5f,0);
                    normal2 = new Vector3(0,.5f,0);
                    normal3 = new Vector3(0,.5f,0);
                    normal4 = new Vector3(0,.5f,0);
                    break;
                
                case Direction.Back:
                    point1 = new Vector3(-.5f, 0, -.5f);
                    point2 = new Vector3(.5f, 0, -.5f);
                    point3 = new Vector3(-.5f, .5f, -.5f);
                    point4 = new Vector3(.5f, .5f, -.5f);
                    
                    triangles = new[]
                    {
                        0,2,3,
                        0,3,1
                    };
                    
                    uv1 = new Vector2(0,0);
                    uv2 = new Vector2(1,0);
                    uv3 = new Vector2(0,1);
                    uv4 = new Vector2(1,1);
                    
                    normal1 = new Vector3(0,0,-.5f);
                    normal2 = new Vector3(0,0,-.5f);
                    normal3 = new Vector3(0,0,-.5f);
                    normal4 = new Vector3(0,0,-.5f);
                    break;
                
                case Direction.Front:
                    point1 = new Vector3(-.5f, 0, .5f);
                    point2 = new Vector3(.5f, 0, .5f);
                    point3 = new Vector3(-.5f, .5f, .5f);
                    point4 = new Vector3(.5f, .5f, .5f);
                    
                    triangles = new[]
                    {
                        0,1,3,
                        0,3,2
                    };
                    
                    uv1 = new Vector2(1,0);
                    uv2 = new Vector2(0,0);
                    uv3 = new Vector2(1,1);
                    uv4 = new Vector2(0,1);
                    
                    normal1 = new Vector3(0,0,.5f);
                    normal2 = new Vector3(0,0,.5f);
                    normal3 = new Vector3(0,0,.5f);
                    normal4 = new Vector3(0,0,.5f);
                    break;
                
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
            
            var mesh = new Mesh
            {
                vertices = new[]
                {
                    point1,
                    point2,
                    point3,
                    point4
                },
                triangles = triangles,
                uv = new[]
                {
                    uv1,
                    uv2,
                    uv3,
                    uv4
                },
                normals = new[]
                {
                    normal1,
                    normal2,
                    normal3,
                    normal4
                }
            };

            mesh.RecalculateBounds();
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();

            return mesh;
        }

        public static Mesh CreatePillar(float x, float y, float z, Vector3 offset)
        {
            var originOffset = new Vector3(-.5f, 0, -.5f);
            
            return new Mesh
            {
                vertices = new[]
                {
                    //Left
                    new Vector3(0, 0, z) + originOffset + offset, 
                    new Vector3(0, 0, 0) + originOffset + offset, 
                    new Vector3(0, y, z) + originOffset + offset, 
                    new Vector3(0, y, 0) + originOffset + offset, 
                                     
                    //Right
                    new Vector3(x, 0, z) + originOffset + offset,  
                    new Vector3(x, 0, 0) + originOffset + offset,  
                    new Vector3(x, y, z) + originOffset + offset,  
                    new Vector3(x, y, 0) + originOffset + offset, 
                                     
                    //Bottom
                    new Vector3(0,0,z) + originOffset + offset,  
                    new Vector3(x,0,z) + originOffset + offset,  
                    new Vector3(x,0,0) + originOffset + offset,  
                    new Vector3(0,0,0) + originOffset + offset, 
                                     
                    //Top
                    new Vector3(0, y, z) + originOffset + offset,  
                    new Vector3(x, y, z) + originOffset + offset, 
                    new Vector3(x, y, 0) + originOffset + offset,  
                    new Vector3(0, y, 0) + originOffset + offset,  
                                     
                    //Back
                    new Vector3(0,0,0) + originOffset + offset,  
                    new Vector3(x,0,0) + originOffset + offset,  
                    new Vector3(0,y,0) + originOffset + offset,  
                    new Vector3(x,y,0) + originOffset + offset,  
                                     
                    //Front
                    new Vector3(0,0,z) + originOffset + offset,  
                    new Vector3(x,0,z) + originOffset + offset,  
                    new Vector3(0,y,z) + originOffset + offset,  
                    new Vector3(x,y,z) + originOffset + offset, 

                },
                triangles = new[]
                {
                    //Left
                    2, 1, 0,
                    2, 3, 1,

                    //Right
                    7, 4, 5,
                    7, 6, 4,

                    //Bottom
                    11, 9, 8,
                    11, 10, 9,

                    //Top
                    12, 14, 15,
                    12, 13, 14,

                    //Back
                    18, 17, 16,
                    18, 19, 17,

                    //Front
                    23, 20, 21,
                    23, 22, 20
                },
                uv = new[]
                {
                    //Left
                    new Vector2(0,0),
                    new Vector2(z,0),
                    new Vector2(0,y),
                    new Vector2(z,y),
 
                    //Right
                    new Vector2(z,0),
                    new Vector2(0,0),
                    new Vector2(z,y),
                    new Vector2(0,y),
                                     
                    //Bottom
                    new Vector2(0,0),
                    new Vector2(x,0),
                    new Vector2(x,z),
                    new Vector2(0,z),
                                     
                    //Top
                    new Vector2(0,z),
                    new Vector2(x,z),
                    new Vector2(x,0),
                    new Vector2(0,0),
                                     
                    //Back
                    new Vector2(0,0),
                    new Vector2(x,0),
                    new Vector2(0,y),
                    new Vector2(x,y),
                                     
                    //Front
                    new Vector2(x,0),
                    new Vector2(0,0),
                    new Vector2(x,y),
                    new Vector2(0,y)
                },
                normals = new[]
                {
                    //Left
                    new Vector3(-.5f, 0, 0),
                    new Vector3(-.5f, 0, 0),
                    new Vector3(-.5f, 0, 0),
                    new Vector3(-.5f, 0, 0),

                    //Right
                    new Vector3(.5f, 0, 0),
                    new Vector3(.5f, 0, 0),
                    new Vector3(.5f, 0, 0),
                    new Vector3(.5f, 0, 0),

                    //Bottom
                    new Vector3(0, -.5f, 0),
                    new Vector3(0, -.5f, 0),
                    new Vector3(0, -.5f, 0),
                    new Vector3(0, -.5f, 0),

                    //Top
                    new Vector3(0, .5f, 0),
                    new Vector3(0, .5f, 0),
                    new Vector3(0, .5f, 0),
                    new Vector3(0, .5f, 0),

                    //Back
                    new Vector3(0, 0, -.5f),
                    new Vector3(0, 0, -.5f),
                    new Vector3(0, 0, -.5f),
                    new Vector3(0, 0, -.5f),

                    //Front
                    new Vector3(0, 0, .5f),
                    new Vector3(0, 0, .5f),
                    new Vector3(0, 0, .5f),
                    new Vector3(0, 0, .5f)
                }
            };
        }
    }
}