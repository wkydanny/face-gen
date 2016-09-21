using UnityEngine;
using System.Collections;

public class FaceGenerator : MonoBehaviour {

    [SerializeField]
    private GameObject[] face;
    [SerializeField]
    private GameObject[] head;
    [SerializeField]
    private GameObject[] eye;
    [SerializeField]
    private GameObject[] nose;
    [SerializeField]
    private GameObject[] mouth;

    private int[] RandomNumber = new int[5];

    // Use this for initialization
    void Start () {
        GetRandom();
        ToggleGO(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleGO(false);
            GetRandom();
            ToggleGO(true);

        }
    }

    void GetRandom()
    {
        RandomNumber[0] = Random.Range(0, face.Length);
        RandomNumber[1] = Random.Range(0, head.Length);
        RandomNumber[2] = Random.Range(0, eye.Length);
        RandomNumber[3] = Random.Range(0, nose.Length);
        RandomNumber[4] = Random.Range(0, mouth.Length);
    }

    void ToggleGO(bool setGO)
    {
        face[RandomNumber[0]].SetActive(setGO);
        head[RandomNumber[1]].SetActive(setGO);
        eye[RandomNumber[2]].SetActive(setGO);
        nose[RandomNumber[3]].SetActive(setGO);
        mouth[RandomNumber[4]].SetActive(setGO);
    }
}
