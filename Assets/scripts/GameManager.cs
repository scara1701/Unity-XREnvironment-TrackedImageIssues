using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    TrackingService trackingService;

    [SerializeField]
    TextMeshProUGUI txtPositions;

    private List<GameObject> instantiatedPrefabs;

    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance != null)
            {
                Debug.Log("Game Manager allready exists!");
            }
                return _instance;
        }
    }


    public void AddPrefab(GameObject prefab)
    {
        if (instantiatedPrefabs == null)
        {
            instantiatedPrefabs = new List<GameObject>();
        }
        instantiatedPrefabs.Add(prefab);

    }

    private void Awake()
    {
        _instance = this;
    }

    private void Update()
    {
        if (txtPositions == null) return;
        if (instantiatedPrefabs == null || instantiatedPrefabs.Count ==0) return;
        string output = "";
        int i = 0;
        foreach (var pf in instantiatedPrefabs)
        {
            i++;
            output = output + $"prefab {i} postion: x-{pf.transform.position.x},y-{pf.transform.position.y},z-{pf.transform.position.z}\n";
            output = output + $"prefab {i} rotaton: x-{pf.transform.rotation.x},y-{pf.transform.rotation.y},z-{pf.transform.rotation.z}\n\n\n";
        }
        txtPositions.text = output;
    }

}
