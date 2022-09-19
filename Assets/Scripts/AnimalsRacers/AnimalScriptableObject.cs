using UnityEngine;
using AnimalRacers;

[CreateAssetMenu(fileName = "AnimalData", menuName = "ScriptableObjects/AnimalScriptableObject", order = 1)]
public class AnimalScriptableObject : ScriptableObject {

    public AnimalType animalType;    
    public string animalName;

    public string[] racerNames;

    public string bio;

    public GameObject prefab;

    public Sprite thumbnail;

    public float impulse;

    public enum AnimalType { RABBIT, DOG, BIRD }

    public static GameObject CreateAnimalRacer (RaceData.Racer racerData, Vector3 position) {
        GameObject runnerObject = runnerObject = Instantiate(racerData.RacerInfo.prefab, position, racerData.RacerInfo.prefab.transform.rotation);
        AnimalRacer animalRacer = null;
        
        switch (racerData.RacerInfo.animalType) {
            case AnimalType.BIRD:                
                animalRacer = runnerObject.AddComponent<BirdRacer>();
                break;
            case AnimalType.DOG:
                animalRacer = runnerObject.AddComponent<DogRacer>();
                break;
            case AnimalType.RABBIT:
                animalRacer = runnerObject.AddComponent<RabbitRacer>();
                break;
        }

        if (animalRacer != null) {
            animalRacer.RacerName = racerData.RacerName;
            animalRacer.Impulse = racerData.RacerImpulse;
        }
        return runnerObject;
    }
}
