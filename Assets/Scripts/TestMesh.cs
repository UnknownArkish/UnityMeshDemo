using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = new Mesh();
        Vector3[] vertices = new Vector3[]
        {
            Vector3.zero,
            new Vector3( 0, 1, 0 ),
            new Vector3( 1, 0, 0 ),
            new Vector3( 1, 1, 0 ),
        };
        mesh.vertices = vertices;

        int[] triangles = new int[]
        {
            0, 1, 2,
            1, 3, 2,
        };
        mesh.triangles = triangles;

        MeshFilter meshFilter = GetComponent<MeshFilter>();
        if (meshFilter == null)
        {
            meshFilter = gameObject.AddComponent<MeshFilter>();
        }
        meshFilter.mesh = mesh;


        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if( meshRenderer == null)
        {
            meshRenderer = gameObject.AddComponent<MeshRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
