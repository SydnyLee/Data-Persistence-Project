using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    [SerializeField] TMP_InputField nameField;

    public string userName = "";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        Instance = this;
    }

    public void StartNew()
    {
        if (nameField.text != "")
        {
            userName = nameField.text;
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("Please enter a name!");
        }
    }
}
