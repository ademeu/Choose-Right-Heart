using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager _instance { get; private set; }
    public int _skor = 1;
    int scoreCarpani = 15;
    public delegate float HizDegis();
    public static HizDegis hizdegis;
    public delegate void ScoreUpdate(int score);
    public static ScoreUpdate scoreDegis;
    private float _objeHiz = 1f;
    [SerializeField] Transform _spawnObje;

    private void Awake()
    {
        scoreDegis += Score;
        hizdegis += GetObjeHiz;

        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
        }
        else if(_instance != this)
        {
            Destroy(_instance);
        }
    }
    private void Update()
    {
        Score(0);
    }

    private float GetObjeHiz()
    {
        return _objeHiz;
    }

    public void UpdateScore()
    {
        _skor++;
    }
    public void ScoreSifir()
    {
        _skor = 1;
    }

    public void Score(int _score)
    {
        _skor += _score;
        if (_skor > scoreCarpani)
        {
            scoreCarpani += 15;
            _objeHiz *= 1.5f;
            foreach (Transform child in _spawnObje)
            {
                Destroy(child.gameObject);
            }
            return;
        }
    }
}
