using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLineScript : MonoBehaviour
{
    public GameObject Panel;
    public GameObject PanelScore;
    public TMP_InputField nameUser;
    public TextMeshProUGUI timeText, scoreText, gAppleText, rAppleText,starText,coinText,swordText,bagText;
    private Timer timer;
    private bool contact = false;
    public Button enviar;
    public Button guardar;
    public Button cerrar;

    [SerializeField] private MovePlayer player;

    private void Start()
    {
        Panel.SetActive(false);
        PanelScore.SetActive(false);
        timer = FindObjectOfType<Timer>();

        if (timer == null)
        {
            Debug.LogError("No se encontró un objeto con el script 'Timer' en la escena.");
        }

        guardar.onClick.AddListener(GuardarJson);
        cerrar.onClick.AddListener(CerrarJuego);
        enviar.onClick.AddListener(MostrarScore);
    }

    private void Update()
    {
        if (contact)
        {
            Timer timer = FindObjectOfType<Timer>();
            if (timer != null)
            {
                timer.TimerStop();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Panel.SetActive(true);
            contact = true;

            if (player != null)
                player.enabled = false;
        }
    }

    private void MostrarScore()
    {
        Panel.SetActive(false);
        PanelScore.SetActive(true);
        ShowFinalScore();
    }

    private void ShowFinalScore()
    {
        Timer timer = FindObjectOfType<Timer>();
        if (timer != null)
        {
            timeText.text = "Tiempo: " + timer.GetElapsedTime();
        }
        scoreText.text = "Score: " + GameManager.Instance.Score;
        gAppleText.text = GameManager.Instance.GreenApple.ToString();
        rAppleText.text = GameManager.Instance.RedApple.ToString();
        swordText.text = GameManager.Instance.Sword.ToString();
        coinText.text = GameManager.Instance.Coin.ToString();
        bagText.text = GameManager.Instance.Bag.ToString();
        starText.text = GameManager.Instance.Star.ToString();
    }

    private void GuardarJson()
    {
        Timer timer = FindObjectOfType<Timer>();
        string tiempoFinal = timer != null ? timer.GetElapsedTime() : "00:00:00";

        GameData data = new GameData(
        nameUser.text,
        GameManager.Instance.Score,
        tiempoFinal,
        GameManager.Instance.GreenApple,
        GameManager.Instance.RedApple,
        GameManager.Instance.Star,
        GameManager.Instance.Sword,
        GameManager.Instance.Coin,
        GameManager.Instance.Bag
);

        string json = JsonUtility.ToJson(data, true);
        string ruta = Application.dataPath+"/Saves/GameScore.json";

        //Crea una carpeta saves
        System.IO.Directory.CreateDirectory(Application.dataPath + "/Saves");
        System.IO.File.WriteAllText(ruta, json);

        //Application.persistentDataPath permite una ruta válida para cada sistema op.

        Debug.Log("Datos guardados en: " + ruta);

    }

    private void CerrarJuego()
    {
        SceneManager.LoadScene("SceneMenu");
    }

}
