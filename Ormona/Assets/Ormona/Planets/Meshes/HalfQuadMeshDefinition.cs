using System.Collections.Generic;
using UnityEngine;

namespace Ormona.Planets.Meshes
 {
     public static class HalfQuadMeshDefinition
     {
         public static readonly Mesh[] Meshes;

         static HalfQuadMeshDefinition()
         {
             var combinationQuads = new Dictionary<int, MeshData>
             {
                 {
                     0,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                                     
                             //Bottom
                             11,9,8,
                             11,10,9,
                                     
                             //Top
                             12,14,15,
                             12,13,14,
                                     
                             //Back
                             18,17,16,
                             18,19,17,
                                     
                             //Front
                             23,20,21,
                             23,22,20
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     1,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0,
                                     
                             //Bottom
                             7,5,4,
                             7,6,5,
                                     
                             //Top
                             8,10,11,
                             8,9,10,
                                     
                             //Back
                             14,13,12,
                             14,15,13,
                                     
                             //Front
                             19,16,17,
                             19,18,16
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     2,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                         
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                         
                             //Bottom
                             7,5,4,
                             7,6,5,
                                     
                             //Top
                             8,10,11,
                             8,9,10,
                                     
                             //Back
                             14,13,12,
                             14,15,13,
                                     
                             //Front
                             19,16,17,
                             19,18,16
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
           
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                         
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     3,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Bottom
                             3,1,0,
                             3,2,1,
                                     
                             //Top
                             4,6,7,
                             4,5,6,
                                     
                             //Back
                             10,9,8,
                             10,11,9,
                                     
                             //Front
                             15,12,13,
                             15,14,12
                         },
                         uvs = new []
                         {
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     4,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                         
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                         
                             //Top
                             8,10,11,
                             8,9,10,
                                     
                             //Back
                             14,13,12,
                             14,15,13,
                                     
                             //Front
                             19,16,17,
                             19,18,16
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
          
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
           
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     5,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                         
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0,
           
                             //Top
                             4,6,7,
                             4,5,6,
                                     
                             //Back
                             10,9,8,
                             10,11,9,
                                     
                             //Front
                             15,12,13,
                             15,14,12
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                         
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                         
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     6,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                         
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                         
                             //Top
                             4,6,7,
                             4,5,6,
                                     
                             //Back
                             10,9,8,
                             10,11,9,
                                     
                             //Front
                             15,12,13,
                             15,14,12
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                         
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
          
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     7,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Top
                             0,2,3,
                             0,1,2,
                                     
                             //Back
                             6,5,4,
                             6,7,5,
                                     
                             //Front
                             11,8,9,
                             11,10,8
                         },
                         uvs = new []
                         {
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     8,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                         
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                                     
                             //Bottom
                             11,9,8,
                             11,10,9,
     
                             //Back
                             14,13,12,
                             14,15,13,
                                     
                             //Front
                             19,16,17,
                             19,18,16
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                         
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                         
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     9,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                         
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0,
                                     
                             //Bottom
                             7,5,4,
                             7,6,5,
                         
                             //Back
                             10,9,8,
                             10,11,9,
                                     
                             //Front
                             15,12,13,
                             15,14,12
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
          
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                         
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     10,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                         
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
    
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
      
                             //Bottom
                             7,5,4,
                             7,6,5,
                             
                             //Back
                             10,9,8,
                             10,11,9,
                                     
                             //Front
                             15,12,13,
                             15,14,12
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                         
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                         
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                         
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
            
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     11,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
         
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Bottom
                             3,1,0,
                             3,2,1,
            
                             //Back
                             6,5,4,
                             6,7,5,
                                     
                             //Front
                             11,8,9,
                             11,10,8
                         },
                         uvs = new []
                         {
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                         
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                         
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     12,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f),
 
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
 
                             //Back
                             10,9,8,
                             10,11,9,
                                     
                             //Front
                             15,12,13,
                             15,14,12
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0),
 
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     13,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f),
 
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0,
 
                             //Back
                             6,5,4,
                             6,7,5,
                                     
                             //Front
                             11,8,9,
                             11,10,8
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                         
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     14,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f),
 
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
 
                             //Back
                             6,5,4,
                             6,7,5,
                                     
                             //Front
                             11,8,9,
                             11,10,8
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0),
 
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     15,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Back
                             2,1,0,
                             2,3,1,
                                     
                             //Front
                             7,4,5,
                             7,6,4
                         },
                         uvs = new []
                         {
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     16,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
           
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                                     
                             //Bottom
                             11,9,8,
                             11,10,9,
                                     
                             //Top
                             12,14,15,
                             12,13,14,
                         
                             //Front
                             19,16,17,
                             19,18,16
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                         
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                         
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     17,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f),
 
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0,
                                     
                             //Bottom
                             7,5,4,
                             7,6,5,
                                     
                             //Top
                             8,10,11,
                             8,9,10,
           
                             //Front
                             15,12,13,
                             15,14,12
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
           
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                         
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     18,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f),
                         
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                         
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                         
                             //Bottom
                             7,5,4,
                             7,6,5,
                                     
                             //Top
                             8,10,11,
                             8,9,10,
             
                             //Front
                             15,12,13,
                             15,14,12
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                         
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
             
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                         
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                         
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     19,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                         
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Bottom
                             3,1,0,
                             3,2,1,
                                     
                             //Top
                             4,6,7,
                             4,5,6,
                         
                             //Front
                             11,8,9,
                             11,10,8
                         },
                         uvs = new []
                         {
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
          
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
            
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     20,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                         
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                         
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                         
                             //Top
                             8,10,11,
                             8,9,10,
           
                             //Front
                             15,12,13,
                             15,14,12
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                         
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
             
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                         
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
         
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
             
                 
                 {
                     24,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f),
 
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                                     
                             //Bottom
                             11,9,8,
                             11,10,9,
 
                             //Front
                             15,12,13,
                             15,14,12
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
 
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0),
 
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     25,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f),
 
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0,
                                     
                             //Bottom
                             7,5,4,
                             7,6,5,
          
                             //Front
                             11,8,9,
                             11,10,8
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
 
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0),
 
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     26,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f),
                         
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f),
 
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                         
                             //Bottom
                             7,5,4,
                             7,6,5,
              
                             //Front
                             11,8,9,
                             11,10,8
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
          
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                         
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                         
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0),
 
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     27,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                         
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Bottom
                             3,1,0,
                             3,2,1,
 
                             //Front
                             7,4,5,
                             7,6,4
                         },
                         uvs = new []
                         {
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
           
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0),
 
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     28,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f),
 
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
 
                             //Front
                             11,8,9,
                             11,10,8
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0),
 
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     29,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                         
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0,
                         
                             //Front
                             7,4,5,
                             7,6,4
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                         
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
           
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     30,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f),
 
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
   
                             //Front
                             7,4,5,
                             7,6,4
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
          
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     31,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Front
                             3,0,1,
                             3,2,0
                         },
                         uvs = new []
                         {
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },
                 {
                     32,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                                     
                             //Bottom
                             11,9,8,
                             11,10,9,
                                     
                             //Top
                             12,14,15,
                             12,13,14,
                                     
                             //Back
                             18,17,16,
                             18,19,17
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 {
                     33,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0,
                                     
                             //Bottom
                             7,5,4,
                             7,6,5,
                                     
                             //Top
                             8,10,11,
                             8,9,10,
                                     
                             //Back
                             14,13,12,
                             14,15,13
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 {
                     34,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f),
                         
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
           
                             //Bottom
                             7,5,4,
                             7,6,5,
                                     
                             //Top
                             8,10,11,
                             8,9,10,
                                     
                             //Back
                             14,13,12,
                             14,15,13
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
         
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
        
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 {
                     35,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Bottom
                             3,1,0,
                             3,2,1,
                                     
                             //Top
                             4,6,7,
                             4,5,6,
                                     
                             //Back
                             10,9,8,
                             10,11,9
                         },
                         uvs = new []
                         {
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 {
                     36,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f),
                         
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                         
                             //Top
                             8,10,11,
                             8,9,10,
                                     
                             //Back
                             14,13,12,
                             14,15,13
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                         
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
          
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 
                 {
                     40,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                         
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                                     
                             //Bottom
                             11,9,8,
                             11,10,9,
 
                             //Back
                             14,13,12,
                             14,15,13
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
          
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
           
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 {
                     41,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                         
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0,
                                     
                             //Bottom
                             7,5,4,
                             7,6,5,
                         
                             //Back
                             10,9,8,
                             10,11,9
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
 
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
          
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 {
                     42,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                         
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                         
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                             
                             //Bottom
                             7,5,4,
                             7,6,5,
                             
                             //Back
                             10,9,8,
                             10,11,9
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
         
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                         
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
            
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 {
                     43,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
            
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Bottom
                             3,1,0,
                             3,2,1,
                         
                             //Back
                             6,5,4,
                             6,7,5
                         },
                         uvs = new []
                         {
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
             
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0),
 
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 {
                     44,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f),
 
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                         
                             //Back
                             10,9,8,
                             10,11,9
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                         
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
         
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 {
                     45,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
           
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0,
         
                             //Back
                             6,5,4,
                             6,7,5
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
         
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                         
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 {
                     46,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                         
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
       
                             //Back
                             6,5,4,
                             6,7,5
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                         
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                         
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 {
                     47,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Back
                             2,1,0,
                             2,3,1
                         },
                         uvs = new []
                         {
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,.5f),
                             new Vector2(1,.5f)
                         },
                         normals = new []
                         {
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f)
                         }
                     }
                 },
                 {
                     48,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                                     
                             //Bottom
                             11,9,8,
                             11,10,9,
                                     
                             //Top
                             12,14,15,
                             12,13,14
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0)
                         }
                     }
                 },
                 {
                     49,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0,
                                     
                             //Bottom
                             7,5,4,
                             7,6,5,
                                     
                             //Top
                             8,10,11,
                             8,9,10
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0)
                         }
                     }
                 },
                 {
                     50,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                         
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                         
                             //Bottom
                             7,5,4,
                             7,6,5,
                                     
                             //Top
                             8,10,11,
                             8,9,10
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                         
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
           
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0)
                         }
                     }
                 },
                 {
                     51,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Bottom
                             3,1,0,
                             3,2,1,
                                     
                             //Top
                             4,6,7,
                             4,5,6
                         },
                         uvs = new []
                         {
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0)
                         },
                         normals = new []
                         {
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0)
                         }
                     }
                 },
                 {
                     52,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                         
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                         
                             //Top
                             8,10,11,
                             8,9,10
 
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                         
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0)
 
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                         
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0)
                         }
                     }
                 },
                 
                 {
                     55,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             0,1,2,
                             0,2,3
                         },
                         uvs = new []
                         {
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0)
                         },
                         normals = new []
                         {
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0)
                         }
                     }
                 },
                 
                 
                 
                 
                 {
                     56,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                                     
                             //Bottom
                             11,9,8,
                             11,10,9
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0)
                         }
                     }
                 },
                 {
                     57,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0,
                                     
                             //Bottom
                             7,5,4,
                             7,6,5
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0)
                         }
                     }
                 },
                 {
                     58,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                         
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
            
                             //Bottom
                             7,5,4,
                             7,6,5
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                         
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                         
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0)
                         }
                     }
                 },
                 {
                     59,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f)
                         },
                         triangles = new []
                         {
                             //Bottom
                             3,1,0,
                             3,2,1
                         },
                         uvs = new []
                         {
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0)
                         }
                     }
                 },
                 {
                     60,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0)
                         }
                     }
                 },
                 {
                     61,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Right
                             3,0,1,
                             3,2,0
                         },
                         uvs = new []
                         {
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0)
                         }
                     }
                 },
                 {
                     62,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0)
                         }
                     }
                 },
                 {
                     63,
                     new MeshData
                     {
                         vertices = new Vector3[0],
                         triangles = new int[0],
                         uvs = new Vector2[0],
                         normals = new Vector3[0]
                     }
                 },
                 /*{
                     63,
                     new MeshData
                     {
                         vertices = new []
                         {
                             //Left
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Right
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Bottom
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, 0, -.5f), 
                                     
                             //Top
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                                     
                             //Back
                             new Vector3(-.5f, 0, -.5f), 
                             new Vector3(.5f, 0, -.5f), 
                             new Vector3(-.5f, .5f, -.5f), 
                             new Vector3(.5f, .5f, -.5f), 
                                     
                             //Front
                             new Vector3(-.5f, 0, .5f), 
                             new Vector3(.5f, 0, .5f), 
                             new Vector3(-.5f, .5f, .5f), 
                             new Vector3(.5f, .5f, .5f)
                         },
                         triangles = new []
                         {
                             //Left
                             2,1,0,
                             2,3,1,
                                     
                             //Right
                             7,4,5,
                             7,6,4,
                                     
                             //Bottom
                             11,9,8,
                             11,10,9,
                                     
                             //Top
                             12,14,15,
                             12,13,14,
                                     
                             //Back
                             18,17,16,
                             18,19,17,
                                     
                             //Front
                             23,20,21,
                             23,22,20
                         },
                         uvs = new []
                         {
                             //Left
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
 
                             //Right
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Bottom
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(1,1),
                             new Vector2(0,1),
                                     
                             //Top
                             new Vector2(0,1),
                             new Vector2(1,1),
                             new Vector2(1,0),
                             new Vector2(0,0),
                                     
                             //Back
                             new Vector2(0,0),
                             new Vector2(1,0),
                             new Vector2(0,1),
                             new Vector2(1,1),
                                     
                             //Front
                             new Vector2(1,0),
                             new Vector2(0,0),
                             new Vector2(1,1),
                             new Vector2(0,1)
                         },
                         normals = new []
                         {
                             //Left
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                             new Vector3(-.5f,0,0), 
                                     
                             //Right
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                             new Vector3(.5f,0,0), 
                                     
                             //Bottom
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                             new Vector3(0,-.5f,0), 
                                     
                             //Top
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                             new Vector3(0,.5f,0), 
                                     
                             //Back
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f), 
                             new Vector3(0,0,-.5f),
                             new Vector3(0,0,-.5f), 
                                     
                             //Front
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f), 
                             new Vector3(0,0,.5f)
                         }
                     }
                 },*/
             };
 
             Meshes = new Mesh[64];        
         
             for (var i = 0; i < 64; i++)
             {
                 if (!combinationQuads.TryGetValue(i, out var meshData))
                 {
                     continue;
                 }
             
                 var mesh = new Mesh
                 {
                     vertices = meshData.vertices, 
                     triangles = meshData.triangles,
                     uv = meshData.uvs,
                     normals = meshData.normals
                 };
 
                 mesh.RecalculateBounds();
             
                 Meshes[i] = mesh;
             }
         }
     }
 }