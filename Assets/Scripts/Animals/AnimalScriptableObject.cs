using UnityEngine;

[CreateAssetMenu(fileName = "AnimalData", menuName = "ScriptableObjects/AnimalScriptableObject", order = 1)]
public class AnimalScriptableObject : ScriptableObject {
    
    public string animalName;

    public string[] racerNames;

    public string bio;

    public GameObject prefab;

    public Sprite thumbnail;

    public float impulse;

}
