using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetInputfieldText : MonoBehaviour
{

    public Button myButton;
    public TMP_Text myText;
    public TMP_InputField myInputField;

    void Start()
    {
        Button btn = myButton.GetComponent<Button>();
        btn.onClick.AddListener(ChangeText);
    }

    public void ChangeText()
    {
        myInputField.text = myText.text;
    }
}
