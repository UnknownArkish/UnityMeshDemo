using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSubMesh : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3[] vertices = new Vector3[]
        {
            Vector3.zero,
            new Vector3( 0, 1, 0 ),
            new Vector3( 1, 0, 0 ),
            new Vector3( 1, 1, 0 ),
        };
        int[] subTriangle_0 = new int[]
        {
            0, 1, 2
        };
        int[] subTriangle_1 = new int[]
        {
            1, 3, 2
        };

        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.subMeshCount = 2;
        mesh.SetTriangles(subTriangle_0, 0);
        mesh.SetTriangles(subTriangle_1, 1);
        mesh.RecalculateNormals();

        MeshFilter meshFilter = GetComponent<MeshFilter>();
        if (meshFilter == null) meshFilter = gameObject.AddComponent<MeshFilter>();
        meshFilter.mesh = mesh;

        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (meshRenderer == null) gameObject.AddComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
