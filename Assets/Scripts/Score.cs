using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // 单例
    public static Score instance;
    
    [SerializeField] private TextMeshProUGUI _currentScoreTxt;
    [SerializeField] private TextMeshProUGUI _bestScoreTxt;

    private int _score;
    private int _bestScore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _currentScoreTxt.text = _score.ToString();
        _bestScore = PlayerPrefs.GetInt("BestScore", 0);
        _bestScoreTxt.text = _bestScore.ToString();
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreTxt.text = _score.ToString();
        UpdateBestScore();
    }
    
    private void UpdateBestScore()
    {
        if (_score > _bestScore)
        {
            _bestScore = _score;
            PlayerPrefs.SetInt("BestScore", _bestScore);
            _bestScoreTxt.text = _bestScore.ToString();
        }
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
