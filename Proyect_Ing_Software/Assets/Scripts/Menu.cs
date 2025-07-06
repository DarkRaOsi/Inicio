using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Importa el namespace para la gestión de escenas

public class Menu : MonoBehaviour
{
    public Button PlayButton;
    // Función pública para cargar una escena por su nombre o índice
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Start()
    {
        PlayButton.onClick.AddListener(StartGame);
    }
}