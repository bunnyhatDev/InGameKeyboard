using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InGameKeyboard : MonoBehaviour {

    public TMP_InputField inputField;       //The text field
    string word = null;                     //The final output in the inputField
    int letterIndex = 0;                    //This is needed to know where the next letter will be placed (can be used to implement a backspace button)

    
    //This function is set on every letter key, once the letter is pressed it will pass that letter into the input field at the end.
    //Go to each button in the inspector you will see this function added under the OnClick() tab with the letter that corrosponds to the button.
    public void InputLetter(string letter) {
        letterIndex++;            //To put the letter at the end by increasing the amount of letters by 1.
        word = word + letter;     //Adding the letter to the overall word with the word already in the text field.
        inputField.text = word;
    }

    //Bonus: A function that clears the input field back to nothing.
    public void ClearField() {
        inputField.text = null;
    }
}
