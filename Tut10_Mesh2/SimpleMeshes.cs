﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fusee.Engine.Core;
using Fusee.Engine.Core.Scene;
using Fusee.Engine.Core.Effects;
using Fusee.Math.Core;
using Fusee.Serialization;


namespace FuseeApp
{
    public static class SimpleMeshes
    {
        public static Mesh CreateCuboid(float3 size)
        {
            return new Mesh
            {
                Vertices = new[]
                {
                    new float3 {x = +0.5f * size.x, y = -0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = +0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = +0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = -0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = -0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = +0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = +0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = -0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = -0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = +0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = +0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = -0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = -0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = +0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = +0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = -0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = +0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = +0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = +0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = +0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = -0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = -0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = -0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = -0.5f * size.y, z = -0.5f * size.z}
                },

                Triangles = new ushort[]
                {
                    // front face
                    0, 2, 1, 0, 3, 2,

                    // right face
                    4, 6, 5, 4, 7, 6,

                    // back face
                    8, 10, 9, 8, 11, 10,

                    // left face
                    12, 14, 13, 12, 15, 14,

                    // top face
                    16, 18, 17, 16, 19, 18,

                    // bottom face
                    20, 22, 21, 20, 23, 22

                },

                Normals = new[]
                {
                    new float3(0, 0, 1),
                    new float3(0, 0, 1),
                    new float3(0, 0, 1),
                    new float3(0, 0, 1),
                    new float3(1, 0, 0),
                    new float3(1, 0, 0),
                    new float3(1, 0, 0),
                    new float3(1, 0, 0),
                    new float3(0, 0, -1),
                    new float3(0, 0, -1),
                    new float3(0, 0, -1),
                    new float3(0, 0, -1),
                    new float3(-1, 0, 0),
                    new float3(-1, 0, 0),
                    new float3(-1, 0, 0),
                    new float3(-1, 0, 0),
                    new float3(0, 1, 0),
                    new float3(0, 1, 0),
                    new float3(0, 1, 0),
                    new float3(0, 1, 0),
                    new float3(0, -1, 0),
                    new float3(0, -1, 0),
                    new float3(0, -1, 0),
                    new float3(0, -1, 0)
                },

                UVs = new[]
                {
                    new float2(1, 0),
                    new float2(1, 1),
                    new float2(0, 1),
                    new float2(0, 0),
                    new float2(1, 0),
                    new float2(1, 1),
                    new float2(0, 1),
                    new float2(0, 0),
                    new float2(1, 0),
                    new float2(1, 1),
                    new float2(0, 1),
                    new float2(0, 0),
                    new float2(1, 0),
                    new float2(1, 1),
                    new float2(0, 1),
                    new float2(0, 0),
                    new float2(1, 0),
                    new float2(1, 1),
                    new float2(0, 1),
                    new float2(0, 0),
                    new float2(1, 0),
                    new float2(1, 1),
                    new float2(0, 1),
                    new float2(0, 0)
                },
                BoundingBox = new AABBf(-0.5f * size, 0.5f * size)
            };
        }

        public static SurfaceEffect MakeMaterial(float4 color)
        {
            return MakeEffect.FromDiffuseSpecular(
                albedoColor: color,
                emissionColor: float3.Zero,
                shininess: 25.0f,
                specularStrength: 1f);
        }

        public static Mesh CreateCylinder(float radius, float height, int segments)
        {
            float uHight = height / 2;
            float bHight = -height / 2;
            // conter clock wise segments rotation
            float alpha = 2 * M.Pi / segments;


            //Double Array Top and Bootom
            float3[][] verts = new float3[2][];
            float3[][] norms = new float3[2][];
            ushort[][] tris = new ushort[2][];

            //Filling the double array 
            verts[0] = new float3[segments + 1];
            verts[1] = new float3[segments + 1];

            norms[0] = new float3[segments + 1];
            norms[1] = new float3[segments + 1];

            tris[0] = new ushort[segments * 3 + 3];
            tris[1] = new ushort[segments * 3 + 3];




            //Bottom faces!
            verts[0][segments] = new float3(0, uHight, 0);
            for (int i = 0; i < segments; i++)
            {
                verts[0][i] = new float3(radius * M.Cos(i * alpha), uHight, radius * M.Sin(i * alpha));
                norms[0][i] = new float3(0, 1, 0);

                tris[0][i * 3 + 0] = (ushort)(i - 1);
                tris[0][i * 3 + 1] = (ushort)i;
                tris[0][i * 3 + 2] = (ushort)segments;
            }


            tris[0][segments * 3 + 0] = (ushort)(segments - 1);
            tris[0][segments * 3 + 1] = (ushort)0;
            tris[0][segments * 3 + 2] = (ushort)(segments);

            //Upper faces!
            verts[1][segments] = new float3(0, bHight, 0);
            for (int i = 0; i < segments; i++)
            {
                verts[1][i] = new float3(radius * M.Cos(i * alpha), bHight, radius * M.Sin(i * alpha));
                norms[1][i] = new float3(0, -1, 0);

                tris[1][i * 3 + 0] = (ushort)(i - 1);
                tris[1][i * 3 + 1] = (ushort)i;
                tris[1][i * 3 + 2] = (ushort)segments;
            }

            tris[1][segments * 3 + 0] = (ushort)(segments - 1);
            tris[1][segments * 3 + 1] = (ushort)0;
            tris[1][segments * 3 + 2] = (ushort)(segments);

            return new Mesh

            {
                Vertices = verts[1],
                Normals = norms[1],
                Triangles = tris[1],
            };
        }

        public static Mesh CreateCone(float radius, float height, int segments)
        {
            return CreateConeFrustum(radius, 0.0f, height, segments);
        }

        public static Mesh CreateConeFrustum(float radiuslower, float radiusupper, float height, int segments)
        {
            throw new NotImplementedException();
        }

        public static Mesh CreatePyramid(float baselen, float height)
        {
            throw new NotImplementedException();
        }
        public static Mesh CreateTetrahedron(float edgelen)
        {
            throw new NotImplementedException();
        }

        public static Mesh CreateTorus(float mainradius, float segradius, int segments, int slices)
        {
            throw new NotImplementedException();
        }

    }


    /*
    public static Mesh CreateCylinder(float radius, float height, int segments)
            {
                float uHight = height / 2;
                float bHight = -height / 2;
                // conter clock wise segments rotation
                float alpha = 2 * M.Pi / segments;


                //Double Array Top and Bootom
                float3[][] verts = new float3[2][];
                float3[][] norms = new float3[2][];
                ushort[][] tris = new ushort[2][];

                //Filling the double array 
                verts[0] = new float3[segments + 1];
                verts[1] = new float3[segments + 1];

                norms[0] = new float3[segments + 1];
                norms[1] = new float3[segments + 1];

                tris[0] = new ushort[segments * 3 + 3];
                tris[1] = new ushort[segments * 3 + 3];




                //Bottom faces!
                verts[0][segments] = new float3(0, uHight, 0);
                for (int i = 0; i < segments; i++)
                {
                    verts[0][i] = new float3(radius * M.Cos(i * alpha), uHight, radius * M.Sin(i * alpha));
                    norms[0][i] = new float3(0, 1, 0);

                    tris[0][i * 3 + 0] = (ushort)(i - 1);
                    tris[0][i * 3 + 1] = (ushort)i;
                    tris[0][i * 3 + 2] = (ushort)segments;
                }


                tris[0][segments * 3 + 0] = (ushort)(segments - 1);
                tris[0][segments * 3 + 1] = (ushort)0;
                tris[0][segments * 3 + 2] = (ushort)(segments);

                //Upper faces!
                verts[1][segments] = new float3(0, bHight, 0);
                for (int i = 0; i < segments; i++)
                {
                    verts[1][i] = new float3(radius * M.Cos(i * alpha), bHight, radius * M.Sin(i * alpha));
                    norms[1][i] = new float3(0, -1, 0);

                    tris[1][i * 3 + 0] = (ushort)(i - 1);
                    tris[1][i * 3 + 1] = (ushort)i;
                    tris[1][i * 3 + 2] = (ushort)segments;
                }

                tris[1][segments * 3 + 0] = (ushort)(segments - 1);
                tris[1][segments * 3 + 1] = (ushort)0;
                tris[1][segments * 3 + 2] = (ushort)(segments);

                return new Mesh
                {

                    Vertices = vertsOut,
                    Normals = norms[1],
                    Triangles = tris[1],
                };
            }
    */
}