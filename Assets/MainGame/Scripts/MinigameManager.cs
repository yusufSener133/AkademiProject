using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> _minigames;
    [SerializeField] GameObject _gameScene;
    [SerializeField] ResourceManager _resourceManager;

    int _randomKey;
    public void Selector(Card card)
    {
        if (_minigames.Count == 0)
            return;


        if (card.IsMinigame && card.ChosenAnswer == AnswersEnum.RightAnswer)
        {

            _randomKey = Random.Range(0, _minigames.Count);
            _minigames[_randomKey].SetActive(true);
            _gameScene.SetActive(false);
        }
    }
    public void Win()
    {
        Debug.Log("Win");
        _minigames[_randomKey].SetActive(false);
        _gameScene.SetActive(true);
        _minigames.Remove(_minigames[_randomKey]);
    }
    public void Lose()
    {
        Debug.Log("Lose");
        _minigames[_randomKey].SetActive(false);
        _gameScene.SetActive(true);
        _minigames.Remove(_minigames[_randomKey]);
    }
}
