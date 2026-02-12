using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NameChanger : MonoBehaviour
{
    public GameObject nameInput;
    private TMP_InputField nameInputField;

    private static TMP_Text nameDisplay;

    void Awake()
    {
        nameInputField = nameInput.GetComponent<TMP_InputField>();
        nameDisplay = gameObject.GetComponent<TMP_Text>();
    }

    void Update()
    {
        nameDisplay.text = nameInputField.text;
    }
}
