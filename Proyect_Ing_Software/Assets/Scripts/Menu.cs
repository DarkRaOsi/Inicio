using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Importa el namespace para la gestión de escenas

public class Menu : MonoBehaviour
{
    public Button PlayButton;
    public Button ExitButton;
    // Función pública para cargar una escena por su nombre o índice
    public void Start()
    {
        PlayButton.onClick.AddListener(StartGame);
        ExitButton.onClick.AddListener(QuitGame);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}