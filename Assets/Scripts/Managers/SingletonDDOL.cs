using UnityEngine;

public class SingletonDDOL<T> : MonoBehaviour
    where T : MonoBehaviour
{
    public static T Instance { get; private set; }
    public static T ddol { get; private set; } = null;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Instance = GetComponent<T>();

        if (ddol)
        {
            Destroy(gameObject);
            return;
        }
    }

    private void OnDestroy()
    {
        Instance = null;
    }
}
