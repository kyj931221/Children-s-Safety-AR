using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class Track : MonoBehaviour
{
    public ARTrackedImageManager manager;

    public List<GameObject> list1 = new List<GameObject>(); // �̹��� ���� ��Ÿ�� ������Ʈ

    private Dictionary<string, GameObject> dict1 = new Dictionary<string, GameObject>();

    private string currentTrackedImageName; // ���� Ʈ��ŷ�� �̹��� �̸�

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject o in list1)
        {
            dict1.Add(o.name, o);
            o.SetActive(false);  // �ʱ⿡�� ��Ȱ��ȭ
        }
    }

    void UpdateImage(ARTrackedImage t)
    {
        string name = t.referenceImage.name;

        if (dict1.TryGetValue(name, out GameObject o))
        {
            if (t.trackingState == TrackingState.Tracking)
            {
                o.transform.position = t.transform.position;
                //o.transform.rotation = t.transform.rotation;
                o.SetActive(true);

                currentTrackedImageName = name; // ���� Ʈ��ŷ�� �̹��� ������Ʈ
            }
            else
            {
                o.SetActive(false);

                if (currentTrackedImageName == name)
                {
                    currentTrackedImageName = null; // �̹����� Ʈ��ŷ���� ���� ��� �ʱ�ȭ
                }
            }
        }
    }

    private void OnChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (ARTrackedImage t in args.added)
        {
            UpdateImage(t);

        }

        foreach (ARTrackedImage t in args.updated)
        {
            UpdateImage(t);
        }
    }

    private void OnEnable()
    {
        manager.trackedImagesChanged += OnChanged;
    }

    private void OnDisable()
    {
        manager.trackedImagesChanged -= OnChanged;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
