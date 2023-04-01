using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class TrackingService : MonoBehaviour
{

    [SerializeField]
    GameObject MyPrefab;

    [SerializeField]
    ARTrackedImageManager m_TrackedImageManager;

    void OnEnable() => m_TrackedImageManager.trackedImagesChanged += OnChanged;

    private void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var newImage in eventArgs.added)
        {
            // Handle added event
            Instantiate(MyPrefab, newImage.transform);
        }

        foreach (var updatedImage in eventArgs.updated)
        {
            // Handle updated event
        }

        foreach (var removedImage in eventArgs.removed)
        {
            // Handle removed event
        }
    }

    void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

    // Start is called before the first frame update
    void Start()
    {
        var desc = m_TrackedImageManager.descriptor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
