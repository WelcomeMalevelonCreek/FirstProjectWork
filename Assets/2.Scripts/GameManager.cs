using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; private set; }

    private int playerHealth;
    private int playerXP;
    private int difficulty = 5;

    public OptionManager OptionManager { get; private set; }
    public AudioManager AudioManager { get; private set; }
    public DeckManager DeckManager { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            initializeManager();
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void initializeManager()
    {
        OptionManager = GetComponentInChildren<OptionManager>();
        AudioManager = GetComponentInChildren<AudioManager>();
        DeckManager = GetComponentInChildren<DeckManager>();

        if (OptionManager == null)
        {
            GameObject prefab = Resources.Load<GameObject>("Prefabs/OptionManager");
            if(prefab == null)
            {
                Debug.Log($"OptionManager prefab not found");
            }
            else
            {
                Instantiate(prefab, transform.position, Quaternion.identity, transform);
                OptionManager = GetComponentInChildren<OptionManager>();
            }
        }

        if (AudioManager == null)
        {
            GameObject prefab = Resources.Load<GameObject>("Prefabs/AudioManager");
            if (prefab == null)
            {
                Debug.Log($"AudioManager prefab not found");
            }
            else
            {
                Instantiate(prefab, transform.position, Quaternion.identity, transform);
                AudioManager = GetComponentInChildren<AudioManager>();
            }
        }

        if (DeckManager == null)
        {
            GameObject prefab = Resources.Load<GameObject>("Prefabs/DeckManager");
            if (prefab == null)
            {
                Debug.Log($"DeckManager prefab not found");
            }
            else
            {
                Instantiate(prefab, transform.position, Quaternion.identity, transform);
                DeckManager = GetComponentInChildren<DeckManager>();
            }
        }
    }

    public int PlayerHealth { get { return playerHealth; } set { playerHealth = value; } }

    public int PlayerXP { get { return playerXP; } set { playerXP = value; } }

    public int Difficulty { get { return difficulty; } set { difficulty = value; } }
}
