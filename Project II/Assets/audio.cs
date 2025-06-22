using UnityEngine;

public class music : MonoBehaviour
{
    private static music instance;

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

            AudioSource audio = GetComponent<AudioSource>();
            if (audio != null)
            {
                audio.loop = true;
                audio.Play();
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}