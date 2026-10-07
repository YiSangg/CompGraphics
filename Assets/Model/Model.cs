using UnityEngine;
using System.Collections.Generic;
public class Model
{
    List<Vector3> vertices  = new List<Vector3>();
    List<Vector3Int> faces = new List< Vector3Int>();


    public Model()
    {

        addVerts();
        addFaces();
    }


    void addVerts()
    {

        vertices.Add(new Vector3(-0.5f, 3.5f, 0f)); // 0
        vertices.Add(new Vector3(0.5f, 3.5f, 0f)); // 1
        vertices.Add(new Vector3(-1.5f, 2.5f, 0f)); // 2

        vertices.Add(new Vector3(-0.5f, 2.5f, 0f)); // 3
        vertices.Add(new Vector3(0.5f, 2.5f, 0f)); // 4
        vertices.Add(new Vector3(1.5f, 2.5f, 0f)); // 5

        vertices.Add(new Vector3(-0.5f, -0.5f, 0f)); // 6
        vertices.Add(new Vector3(0.5f, -0.5f, 0f)); // 7 
        vertices.Add(new Vector3(-0.5f, -1.5f, 0f)); // 8

        vertices.Add(new Vector3(0.5f, -1.5f, 0f)); // 9 
        vertices.Add(new Vector3(-1.5f, -3.5f, 0f)); // 10
        vertices.Add(new Vector3(-0.5f, -3.5f, 0f)); // 11

        vertices.Add(new Vector3(0.5f, -3.5f, 0f)); // 12
        vertices.Add(new Vector3(1.5f, -3.5f, 0f)); // 13

// BACKFACE

        vertices.Add(new Vector3(-0.5f, 3.5f, 0.5f)); // 14 0
        vertices.Add(new Vector3(0.5f, 3.5f, 0.5f)); // 15 1 
        vertices.Add(new Vector3(-1.5f, 2.5f, 0.5f)); // 16 2

        vertices.Add(new Vector3(-0.5f, 2.5f, 0.5f)); // 17 3
        vertices.Add(new Vector3(0.5f, 2.5f, 0.5f)); // 18 4 
        vertices.Add(new Vector3(1.5f, 2.5f, 0.5f)); // 19 5

        vertices.Add(new Vector3(-0.5f, -0.5f, 0.5f)); // 20 6
        vertices.Add(new Vector3(0.5f, -0.5f, 0.5f)); // 21 7
        vertices.Add(new Vector3(-0.5f, -1.5f, 0.5f)); // 22 8

        vertices.Add(new Vector3(0.5f, -1.5f, 0.5f)); // 23 9
        vertices.Add(new Vector3(-1.5f, -3.5f, 0.5f)); // 24 10
        vertices.Add(new Vector3(-0.5f, -3.5f, 0.5f)); // 25 11

        vertices.Add(new Vector3(0.5f, -3.5f, 0.5f)); // 26 12
        vertices.Add(new Vector3(1.5f, -3.5f, 0.5f)); // 27 13

    }

    void addFaces()
    {

    // FRONTFACE

        faces.Add(new Vector3Int(0,2,3)); //1
        faces.Add(new Vector3Int(3,2,10)); //2
        faces.Add(new Vector3Int(3,10,11)); //3
        faces.Add(new Vector3Int(0,3,1)); //4
        faces.Add(new Vector3Int(1,3,4)); //5
        faces.Add(new Vector3Int(1,4,5)); //6
        faces.Add(new Vector3Int(5,4,12)); //7
        faces.Add(new Vector3Int(5,12,13)); //8
        faces.Add(new Vector3Int(6,8,7)); //9
        faces.Add(new Vector3Int(7,8,9)); //10

    // BACKFACE
    
        faces.Add(new Vector3Int(14,16,17)); //1
        faces.Add(new Vector3Int(17,16,24)); //2
        faces.Add(new Vector3Int(17,24,25)); //3
        faces.Add(new Vector3Int(14,17,15)); //4
        faces.Add(new Vector3Int(15,17,18)); //5
        faces.Add(new Vector3Int(15,18,19)); //6
        faces.Add(new Vector3Int(19,18,26)); //7
        faces.Add(new Vector3Int(19,26,27)); //8
        faces.Add(new Vector3Int(20,22,21)); //9
        faces.Add(new Vector3Int(21,22,23)); //10

    //SIDEFACE

        faces.Add(new Vector3Int(0,14,1));
        faces.Add(new Vector3Int(1,14,15));
        faces.Add(new Vector3Int(1,19,5));
        faces.Add(new Vector3Int(1,15,19)); 
        faces.Add(new Vector3Int(16,14,0));
        faces.Add(new Vector3Int(0,2,16));
        
        faces.Add(new Vector3Int(7,6,21));
        faces.Add(new Vector3Int(6,20,21));

        faces.Add(new Vector3Int(17,20,6));
        faces.Add(new Vector3Int(6,3,17));

        faces.Add(new Vector3Int(7,21,18));
        faces.Add(new Vector3Int(18,4,7));

        faces.Add(new Vector3Int(18,17,3));
        faces.Add(new Vector3Int(3,4,18));

        faces.Add(new Vector3Int(24,16,2)); //SIDE OF A
        faces.Add(new Vector3Int(10,24,2));

        faces.Add(new Vector3Int(19,27,13)); //SIDE OF A
        faces.Add(new Vector3Int(13,5,19));

        faces.Add(new Vector3Int(8,22,25));
        faces.Add(new Vector3Int(11,8,25));

        faces.Add(new Vector3Int(9,12,26));
        faces.Add(new Vector3Int(9,26,23));

        faces.Add(new Vector3Int(25,24,10));
        faces.Add(new Vector3Int(25,10,11));

        faces.Add(new Vector3Int(27,26,12));
        faces.Add(new Vector3Int(27,12,13));

        faces.Add(new Vector3Int(23,22,8));
        faces.Add(new Vector3Int(23,8,9));

        for (int i = 0; i < vertices.Count; i++)
        {
            Debug.Log($"Base Vertex {i}: {vertices[i].ToString("F3")}");
        }


    }

    

    
    public GameObject CreateUnityGameObject()
    {
        Mesh mesh = new Mesh();
        GameObject newGO = new GameObject();
     
        MeshFilter mesh_filter = newGO.AddComponent<MeshFilter>();
        MeshRenderer mesh_renderer = newGO.AddComponent<MeshRenderer>();

        List<Vector3> coords = new List<Vector3>();
        List<int> dummy_indices = new List<int>();
        List<Vector2> text_coords = new List<Vector2>();
        List<Vector3> normalz = new List<Vector3>();
//fghfg
        for (int i = 0; i < faces.Count; i++)
            if (i < 10){
                {
                //Vector3 normal_for_face = normals[i];

                //normal_for_face = new Vector3(normal_for_face.x, normal_for_face.y, -normal_for_face.z);

                coords.Add(vertices[faces[i].x]); dummy_indices.Add(i * 3); //text_coords.Add(texture_coordinates[texture_index_list[i].x]); normalz.Add(normal_for_face);

                coords.Add(vertices[faces[i].y]); dummy_indices.Add(i * 3 + 2); //text_coords.Add(texture_coordinates[texture_index_list[i].y]); normalz.Add(normal_for_face);

                coords.Add(vertices[faces[i].z]); dummy_indices.Add(i * 3 + 1); //text_coords.Add(texture_coordinates[texture_index_list[i].z]); normalz.Add(normal_for_face);
                }   
            }
            else{
{
                //Vector3 normal_for_face = normals[i];

                //normal_for_face = new Vector3(normal_for_face.x, normal_for_face.y, -normal_for_face.z);

                coords.Add(vertices[faces[i].x]); dummy_indices.Add(i * 3); //text_coords.Add(texture_coordinates[texture_index_list[i].x]); normalz.Add(normal_for_face);

                coords.Add(vertices[faces[i].y]); dummy_indices.Add(i * 3 + 1); //text_coords.Add(texture_coordinates[texture_index_list[i].y]); normalz.Add(normal_for_face);

                coords.Add(vertices[faces[i].z]); dummy_indices.Add(i * 3 + 2); //text_coords.Add(texture_coordinates[texture_index_list[i].z]); normalz.Add(normal_for_face);
                }   
            }
        

        mesh.vertices = coords.ToArray();
        mesh.triangles = dummy_indices.ToArray();
        /*mesh.uv = text_coords.ToArray();
        mesh.normals = normalz.ToArray();*/
        mesh_filter.mesh = mesh;

        return newGO;
    }


}
