using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
        {
                if(other.CompareTag("Player"))
                        {
                                    Debug.Log("Collectible ramassé !");
                                                // Incrémente ton score ou déclenche un effet ici.
                                                            Destroy(gameObject);
                                                                    }
                                                                        }
                                                                        }
