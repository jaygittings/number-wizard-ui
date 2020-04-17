using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    int guess;

    [SerializeField] TextMeshProUGUI numberText;
    [SerializeField] int minNumber;
    [SerializeField] int maxNumber;
    [SerializeField] Text instructions;

    // Start is called before the first frame update
    void Start()
    {
        instructions.text = string.Format("Please guess a number between {0} and {1}", minNumber, maxNumber);
        //maxNumber++;
        guess = NextGuess();
    }

    public void OnPressHigher()
    {
        minNumber = guess + 1 < maxNumber ? guess + 1 : maxNumber;
        NextGuess();
    }

    public void OnPressLower()
    {
        maxNumber = guess - 1 < minNumber ? minNumber : guess - 1;
        NextGuess();
    }

    int NextGuess()
    {
        guess = Random.Range(minNumber, maxNumber + 1);
        numberText.text = guess.ToString();
        return guess;
    }
}
