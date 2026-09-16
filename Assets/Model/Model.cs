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

        vertices.Add(new Vector3(-0.5f, 3.5f, 1f)); // 0
        vertices.Add(new Vector3(0.5f, 3.5f, 1f)); // 1
        vertices.Add(new Vector3(-1.5f, 2.5f, 1f)); // 2

        vertices.Add(new Vector3(-0.5f, 2.5f, 1f)); // 3
        vertices.Add(new Vector3(0.5f, 2.5f, 1f)); // 4
        vertices.Add(new Vector3(1.5f, 2.5f, 1f)); // 5

        vertices.Add(new Vector3(-0.5f, -0.5f, 1f)); // 6
        vertices.Add(new Vector3(0.5f, -0.5f, 1f)); // 7 
        vertices.Add(new Vector3(-0.5f, -1.5f, 1f)); // 8

        vertices.Add(new Vector3(0.5f, -1.5f, 1f)); // 9 
        vertices.Add(new Vector3(-1.5f, -3.5f, 1f)); // 10
        vertices.Add(new Vector3(-0.5f, -3.5f, 1f)); // 11

        vertices.Add(new Vector3(0.5f, -3.5f, 1f)); // 12
        vertices.Add(new Vector3(1.5f, -3.5f, 1f)); // 13

    }

    void addFaces()
    {

        faces.Add(new Vector3Int(0,10,2));
    }

    
    public GameObject CreateUnityGameObject()
    {
        Mesh mesh = new Mesh();
        GameObject newGO = new GameObject();
     
        MeshFilter mesh_filter = newGO.AddComponent<MeshFilter>();
        MeshRenderer mesh_renderer = newGO.AddComponent<MeshRenderer>();

        List<Vector3> coords = new List<Vector3>();
        List<int> dummy_indices = new List<int>();
        /*List<Vector2> text_coords = new List<Vector2>();
        List<Vector3> normalz = new List<Vector3>();*/
//fghfg
        for (int i = 0; i < faces.Count; i++)
        {
            //Vector3 normal_for_face = normals[i];

            //normal_for_face = new Vector3(normal_for_face.x, normal_for_face.y, -normal_for_face.z);

            coords.Add(vertices[faces[i].x]); dummy_indices.Add(i * 3); //text_coords.Add(texture_coordinates[texture_index_list[i].x]); normalz.Add(normal_for_face);

            coords.Add(vertices[faces[i].y]); dummy_indices.Add(i * 3 + 2); //text_coords.Add(texture_coordinates[texture_index_list[i].y]); normalz.Add(normal_for_face);

            coords.Add(vertices[faces[i].z]); dummy_indices.Add(i * 3 + 1); //text_coords.Add(texture_coordinates[texture_index_list[i].z]); normalz.Add(normal_for_face);
        }

        mesh.vertices = coords.ToArray();
        mesh.triangles = dummy_indices.ToArray();
        /*mesh.uv = text_coords.ToArray();
        mesh.normals = normalz.ToArray();*/
        mesh_filter.mesh = mesh;

        return newGO;
    }


}
