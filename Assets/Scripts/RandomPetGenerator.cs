using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//make sure the pet generator game object is placed at the centre of the scene
public class RandomPetGenerator : MonoBehaviour {

    public GameObject[] DifferentPets;
    public int MinNumberOfPets = 10;
    public int MaxNumberOfPets = 20;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < Random.Range(MinNumberOfPets, MaxNumberOfPets); i++) {
            PetGenerate();
        }	
	}
	
	// Update is called once per frame
	void Update () {
 
	}

    //generate multiple pets at random positions
    void PetGenerate() {
        int petIndex = Random.Range(0, DifferentPets.Length);
        GameObject pet = Instantiate(DifferentPets[petIndex]);
        pet.transform.parent = transform;

        //range of pet generation area: X = -10 to 10, Z = -10 to 10, fixed y pos
        pet.transform.localPosition = new Vector3(Random.Range(-15, 15), 0.5f, Random.Range(-15, 15));

        //Prevent instantiation on top of other objects

        Debug.Log(petIndex);

    }
}
