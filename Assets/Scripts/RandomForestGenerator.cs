using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForestGenerator : MonoBehaviour {

    public GameObject[] DifferentTrees;
    public int MinNumberOfTrees = 50;
    public int MaxNumberOfTrees = 60;

    public GameObject[] DifferentGrass;
    public int MinNumberOfGrass = 90;
    public int MaxNumberOfGrass = 100;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < Random.Range(MinNumberOfTrees, MaxNumberOfTrees); i++)
        {
            TreeGenerate();
        }

        for (int j = 0; j < Random.Range(MinNumberOfGrass, MaxNumberOfGrass); j++)
        {
            GrassGenerate();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    //generate multiple pets at random positions
    void TreeGenerate()
    {
        int treeIndex = Random.Range(0, DifferentTrees.Length);
        GameObject tree = Instantiate(DifferentTrees[treeIndex]);
        tree.transform.parent = transform;
        //range of pet generation area: X = -10 to 10, Z = -10 to 10, fixed y pos
        tree.transform.localPosition = new Vector3(Random.Range(-20, 20), 1.0f, Random.Range(-20, 20));
        //Debug.Log(treeIndex);
    }

    void GrassGenerate() {
        int grassIndex = Random.Range(0, DifferentGrass.Length);
        GameObject grass = Instantiate(DifferentGrass[grassIndex]);
        grass.transform.parent = transform;
        //range of pet generation area: X = -10 to 10, Z = -10 to 10, fixed y pos
        grass.transform.localPosition = new Vector3(Random.Range(-20, 20), 0.8f, Random.Range(-20, 20));
        //Debug.Log(grassIndex);
    }
}
