using UnityEngine;

public class TrapManager : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
        {
                if(other.CompareTag("Player"))
                        {
                                    Debug.Log("Piège activé !");
                                                // Ici, tu peux ajouter la logique pour réinitialiser la position ou diminuer une vie.
                                                        }
                                                            }
                                                            }
