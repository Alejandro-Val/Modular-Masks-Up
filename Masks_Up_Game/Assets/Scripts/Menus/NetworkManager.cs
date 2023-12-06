using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class NetworkManager : MonoBehaviour
{
    [Header("Login")]
    [SerializeField] private TMP_InputField m_userNameLogInput = null;
    [SerializeField] private TMP_InputField m_passwordLogInput = null;

    [Header("Register")]
    [SerializeField] private TMP_InputField m_userNameInput = null;
    [SerializeField] private TMP_InputField m_passwordInput = null;
    [SerializeField] private TMP_InputField m_passwordConfirmInput = null;
    [SerializeField] private TMP_InputField m_ageInput = null;
    [SerializeField] private TextMeshProUGUI m_text = null;
    [SerializeField] private TextMeshProUGUI gamertag_text = null;
    [SerializeField] private TextMeshProUGUI nombre = null;
    [SerializeField] private TextMeshProUGUI diagnosis_txt = null;

    [Header("Fondos")]
    public GameObject fondoPrincipal;
    public GameObject fondoPerfil;
    public GameObject fondoPerfilPropio;
    public GameObject Login;
    public GameObject Singin;
    public GameObject AdvertenciaErrorDeRed;
    public GameObject fondoNegro;
    public GameObject fondoTerminosYCondiciones;
    public GameObject TerminosYCondiciones;

    [Header("Datos Usuario")]
    [SerializeField] private TextMeshProUGUI playTimeText = null;
    public string nombreUsuario;

    [Header("Scripts")]
    [SerializeField] private TimeManager m_timeManager;

    public void start(){
        m_timeManager = GetComponent<TimeManager>();
    }

    public void MostrarAdvertencia(){
        fondoNegro.SetActive(true);
        LeanTween.scaleX(AdvertenciaErrorDeRed, 1, 0.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scaleY(AdvertenciaErrorDeRed, 1, 0.5f).setEase(LeanTweenType.easeOutElastic);
    }

    public void DesactivarAdvertencia(){
        fondoNegro.SetActive(false);
        LeanTween.scaleX(AdvertenciaErrorDeRed, 0, 0.5f).setEase(LeanTweenType.easeInOutExpo);
        LeanTween.scaleY(AdvertenciaErrorDeRed, 0, 0.5f).setEase(LeanTweenType.easeInOutExpo);
    }

    public void cancellSubmitSingin(){
        fondoTerminosYCondiciones.SetActive(false);
        LeanTween.scale(TerminosYCondiciones, new Vector2(0f,0f), 0.2f).setEase(LeanTweenType.easeInOutExpo);
    }

    public void submitSingin()
    {
        if(m_userNameInput.text == "" || m_passwordInput.text == "" || m_passwordConfirmInput.text == "" || m_ageInput.text == ""){
            m_text.text = "Por favor, llena todos los campos";
            return;
        }
        if(m_passwordInput.text != m_passwordConfirmInput.text)
        {
            m_text.text = "Las contraseñas no coinciden, vuelve a intentarlo";
            return;
        }
        m_text.text = "Para continuar, es necesario que aceptes los términos y condiciones";
        fondoTerminosYCondiciones.SetActive(true);
        LeanTween.scale(TerminosYCondiciones, new Vector2(1f,1f), 0.2f).setEase(LeanTweenType.easeOutElastic);
    }

    public void InitSingIn(){
        fondoTerminosYCondiciones.SetActive(false);
        LeanTween.scale(TerminosYCondiciones, new Vector2(0f,0f), 0.2f).setEase(LeanTweenType.easeInOutExpo);
        CreateUser(m_userNameInput.text, m_passwordInput.text, m_ageInput.text);
    }

    public void CreateUser(string username, string password, string age)
    {
        StartCoroutine(CO_CreateUser(username, password, age));
    }

    private IEnumerator CO_CreateUser(string username, string password, string age)
    {
        string url = "https://masksupmodulardb.000webhostapp.com/createUser.php";

        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);
        form.AddField("age", age);
        UnityWebRequest request = UnityWebRequest.Post(url, form);

        yield return request.SendWebRequest();

        if (request.isNetworkError || request.isHttpError)
        {
            MostrarAdvertencia();
        }
        else
        {
            m_text.text = request.downloadHandler.text;
            Debug.Log(request.downloadHandler.text);
            if(request.downloadHandler.text == "Cuenta creada"){
                nombreUsuario = username;
                gamertag_text.text = nombreUsuario;
                nombre.text = nombreUsuario;
                PlayerPrefs.SetString("NombreUsuario", nombreUsuario);
                BorrarEntrys();
            }
        }
    }

    public void submitLogin()
    {
        if(m_userNameLogInput.text == "" || m_passwordLogInput.text == ""){
            m_text.text = "Ingresa tu nombre de usuario y contraseña";
            return;
        }
        m_text.text = "Cargando...";
        checkUser(m_userNameLogInput.text, m_passwordLogInput.text);
    }

    public void checkUser(string username, string password)
    {
        Debug.Log("entro");
        StartCoroutine(CO_checkUser(username, password));
    }

    private IEnumerator CO_checkUser(string username, string password)
    {
        Debug.Log("Empezo");
        string url = "https://masksupmodulardb.000webhostapp.com/chekUser.php";
    
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);
        UnityWebRequest request = UnityWebRequest.Post(url, form);

        yield return request.SendWebRequest();
        
        if (request.isNetworkError || request.isHttpError)
        {
            MostrarAdvertencia();
        }
        else
        {
            m_text.text = request.downloadHandler.text;
            Debug.Log(request.downloadHandler.text);

            if(request.downloadHandler.text == "Iniciando sesión"){
                nombreUsuario = username;
                gamertag_text.text = nombreUsuario;
                nombre.text = nombreUsuario;
                PlayerPrefs.SetString("NombreUsuario", nombreUsuario);

                url = "https://masksupmodulardb.000webhostapp.com/DescargarLogros.php";
                WWWForm form2 = new WWWForm();
                form2.AddField("username", username);
                UnityWebRequest request2 = UnityWebRequest.Post(url, form2);

                yield return request2.SendWebRequest();

                string responseJson = request2.downloadHandler.text;
                
                responseJson = responseJson.Replace("\"", "").Replace("[", "").Replace("]", "");
                string[] elementos = responseJson.Split(',');

                int[] logros = new int[elementos.Length];
                for (int i = 0; i < elementos.Length; i++)
                {
                    logros[i] = int.Parse(elementos[i]);
                }

                url = "https://masksupmodulardb.000webhostapp.com/DescargarHoras.php";
                WWWForm form3 = new WWWForm();
                form3.AddField("username", username);
                UnityWebRequest request3 = UnityWebRequest.Post(url, form3);

                yield return request3.SendWebRequest();

                string responseJson2 = request3.downloadHandler.text;
                
                float NuevasHoras = float.Parse(responseJson2);
                PlayerPrefs.SetFloat("PlayTime", NuevasHoras);
                float playTime = PlayerPrefs.GetFloat("PlayTime", 0f);
                int hours = Mathf.FloorToInt(playTime / 3600);
                int minutes = Mathf.FloorToInt((playTime - hours * 3600) / 60);
                int seconds = Mathf.FloorToInt(playTime - hours * 3600 - minutes * 60);
                playTimeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);

                m_timeManager.Actualizar(NuevasHoras);

                url = "https://masksupmodulardb.000webhostapp.com/DescargarDiagnosis.php";
                WWWForm form4 = new WWWForm();
                form4.AddField("username", username);
                UnityWebRequest request4 = UnityWebRequest.Post(url, form4);

                yield return request4.SendWebRequest();

                string diagnosis = request4.downloadHandler.text;

                diagnosis_txt.text = diagnosis;
                PlayerPrefs.SetString("diagnosis", diagnosis);

                CargarLogros(logros);
                BorrarEntrys();
            }
        }
    }

    public void GuardarPartida()
    {
        string nombre = PlayerPrefs.GetString("NombreUsuario");
        string diagnosis = PlayerPrefs.GetString("diagnosis");
        float horas = PlayerPrefs.GetFloat("PlayTime");
        Guardar(nombre, diagnosis, horas);
    }

    public void Guardar(string nombre, string diagnosis, float horas)
    {
        Debug.Log("entro a guardar");
        StartCoroutine(CO_GuardarPartida(nombre, diagnosis, horas));
    }

    private IEnumerator CO_GuardarPartida(string nombre, string diagnosis, float horas)
    {
        int logro1 = PlayerPrefs.GetInt("Logro1");
        int logro2 = PlayerPrefs.GetInt("Logro2");
        int logro3 = PlayerPrefs.GetInt("Logro3");
        int logro4 = PlayerPrefs.GetInt("Logro4");
        int logro5 = PlayerPrefs.GetInt("Logro5");
        int logro6 = PlayerPrefs.GetInt("Logro6");
        int logro7 = PlayerPrefs.GetInt("Logro7");
        int logro8 = PlayerPrefs.GetInt("Logro8");
        int logro9 = PlayerPrefs.GetInt("Logro9");
        int logro10 = PlayerPrefs.GetInt("Logro10");
        int logro11 = PlayerPrefs.GetInt("Logro11");
        
        Debug.Log("Empezo");
        string url = "https://masksupmodulardb.000webhostapp.com/GuardarPartida.php";
    
        WWWForm form = new WWWForm();
        form.AddField("username", nombre);
        form.AddField("diagnosis", diagnosis);
        form.AddField("horas", horas.ToString());
        form.AddField("achievement1", logro1.ToString());
        form.AddField("achievement2", logro2.ToString());
        form.AddField("achievement3", logro3.ToString());
        form.AddField("achievement4", logro4.ToString());
        form.AddField("achievement5", logro5.ToString());
        form.AddField("achievement6", logro6.ToString());
        form.AddField("achievement7", logro7.ToString());
        form.AddField("achievement8", logro8.ToString());
        form.AddField("achievement9", logro9.ToString());
        form.AddField("achievement10", logro10.ToString());
        form.AddField("achievement11", logro11.ToString());
        UnityWebRequest request = UnityWebRequest.Post(url, form);

        yield return request.SendWebRequest();

        if (request.isNetworkError || request.isHttpError)
        {
            MostrarAdvertencia();
        }
        else
        {
            Debug.Log(request.downloadHandler.text);
        }
    }

    public void CargarPartida()
    {
        string nombre = PlayerPrefs.GetString("NombreUsuario");
        Cargar(nombre);
    }

    public void Cargar(string username)
    {
        Debug.Log("entro");
        StartCoroutine(CO_CargarPartida(username));
    }

    private IEnumerator CO_CargarPartida(string username)
    {
        string url = "https://masksupmodulardb.000webhostapp.com/DescargarLogros.php";
        WWWForm form2 = new WWWForm();
        form2.AddField("username", username);
        UnityWebRequest request2 = UnityWebRequest.Post(url, form2);

        yield return request2.SendWebRequest();

        if (request2.isNetworkError || request2.isHttpError)
        {
            MostrarAdvertencia();
        }
        else
        {
            string responseJson = request2.downloadHandler.text;
                
            responseJson = responseJson.Replace("\"", "").Replace("[", "").Replace("]", "");
            string[] elementos = responseJson.Split(',');

            int[] logros = new int[elementos.Length];
            for (int i = 0; i < elementos.Length; i++)
            {
                logros[i] = int.Parse(elementos[i]);
            }

            url = "https://masksupmodulardb.000webhostapp.com/DescargarHoras.php";
            WWWForm form3 = new WWWForm();
            form3.AddField("username", username);
            UnityWebRequest request3 = UnityWebRequest.Post(url, form3);

            yield return request3.SendWebRequest();

            string responseJson2 = request3.downloadHandler.text;
                
            float NuevasHoras = float.Parse(responseJson2);
            PlayerPrefs.SetFloat("PlayTime", NuevasHoras);
            float playTime = PlayerPrefs.GetFloat("PlayTime", 0f);
            int hours = Mathf.FloorToInt(playTime / 3600);
            int minutes = Mathf.FloorToInt((playTime - hours * 3600) / 60);
            int seconds = Mathf.FloorToInt(playTime - hours * 3600 - minutes * 60);
            playTimeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);

            m_timeManager.Actualizar(NuevasHoras);

            url = "https://masksupmodulardb.000webhostapp.com/DescargarDiagnosis.php";
            WWWForm form4 = new WWWForm();
            form4.AddField("username", username);
            UnityWebRequest request4 = UnityWebRequest.Post(url, form4);

            yield return request4.SendWebRequest();

            string diagnosis = request4.downloadHandler.text;

            diagnosis_txt.text = diagnosis;
            PlayerPrefs.SetString("diagnosis", diagnosis);

            CargarLogros(logros);
        }
    }

    public void CargarLogros(int[] logros){
        PlayerPrefs.SetInt("Logro1", logros[0]);
        PlayerPrefs.SetInt("Logro2", logros[1]);
        PlayerPrefs.SetInt("Logro3", logros[2]);
        PlayerPrefs.SetInt("Logro4", logros[3]);
        PlayerPrefs.SetInt("Logro5", logros[4]);
        PlayerPrefs.SetInt("Logro6", logros[5]);
        PlayerPrefs.SetInt("Logro7", logros[6]);
        PlayerPrefs.SetInt("Logro8", logros[7]);
        PlayerPrefs.SetInt("Logro9", logros[8]);
        PlayerPrefs.SetInt("Logro10", logros[9]);
        PlayerPrefs.SetInt("Logro11", logros[10]);
        ComprobarLogros(logros);
    }

    public void ComprobarLogros(int[] logros){
        PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia1");
        logros[0] = PlayerPrefs.GetInt("Logro1");
        if(logros[0] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia2");
        }

        logros[1] = PlayerPrefs.GetInt("Logro2");
        if(logros[1] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia3");
        }
        
        logros[2] = PlayerPrefs.GetInt("Logro3");
        if(logros[2] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia4");
        }
        
        logros[3] = PlayerPrefs.GetInt("Logro4");
        if(logros[3] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia5");
        }
        
        logros[4] = PlayerPrefs.GetInt("Logro5");
        if(logros[4] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia6");
        }
        
        logros[5] = PlayerPrefs.GetInt("Logro6");
        if(logros[5] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia7");
        }
        
        logros[6] = PlayerPrefs.GetInt("Logro7");
        if(logros[6] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia8");
        }
        
        logros[7] = PlayerPrefs.GetInt("Logro8");
        if(logros[7] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia9");
        }
        
        logros[8] = PlayerPrefs.GetInt("Logro9");
        if(logros[8] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia10");
        }
        
        logros[9] = PlayerPrefs.GetInt("Logro10");
        if(logros[9] > 0){
            PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia11");
        }
    }

    public void CerrarSesion(){
        nombreUsuario = "";
        gamertag_text.text = nombreUsuario;
        diagnosis_txt.text = nombreUsuario;

        PlayerPrefs.SetString("NombreUsuario", nombreUsuario);

        float reinicio = 0f;
        PlayerPrefs.SetFloat("PlayTime", reinicio);
        float playTime = PlayerPrefs.GetFloat("PlayTime", 0f);
        int hours = Mathf.FloorToInt(playTime / 3600);
        int minutes = Mathf.FloorToInt((playTime - hours * 3600) / 60);
        int seconds = Mathf.FloorToInt(playTime - hours * 3600 - minutes * 60);
        playTimeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);
        
        PlayerPrefs.DeleteKey("Logro1");
        PlayerPrefs.DeleteKey("Logro2");
        PlayerPrefs.DeleteKey("Logro3");
        PlayerPrefs.DeleteKey("Logro4");
        PlayerPrefs.DeleteKey("Logro5");
        PlayerPrefs.DeleteKey("Logro6");
        PlayerPrefs.DeleteKey("Logro7");
        PlayerPrefs.DeleteKey("Logro8");
        PlayerPrefs.DeleteKey("Logro9");
        PlayerPrefs.DeleteKey("Logro10");
        PlayerPrefs.DeleteKey("Logro11");
        PlayerPrefs.SetString("DiaActual", "Escenario0CuartoDia1");

        BorrarEntrys();
    }

    public void BorrarEntrys(){
        m_userNameLogInput.text = "";
        m_passwordLogInput.text = "";
        m_userNameInput.text = "";
        m_passwordInput.text = "";
        m_passwordConfirmInput.text = "";
        m_ageInput.text = "";
        m_text.text = "";
        if(fondoPerfil.activeSelf == true){
            LeanTween.scale(fondoPerfil, new Vector2(3f,3f), 0.2f).setEase(LeanTweenType.easeOutSine).setOnComplete(DesactivarObjetos);
        }
        if(fondoPerfilPropio.activeSelf == true){
            LeanTween.scale(fondoPerfilPropio, new Vector2(3f,3f), 0.2f).setEase(LeanTweenType.easeOutSine).setOnComplete(DesactivarObjetos);
        }
    }

    public void DesactivarObjetos(){
        fondoPerfil.SetActive(false);
        fondoPerfilPropio.SetActive(false);
        Singin.SetActive(false);
        Login.SetActive(false);
        LeanTween.scale(fondoPrincipal, new Vector2(1f,1f), 0.2f).setEase(LeanTweenType.easeInSine);
    }

    public void BorrarEntrysSimple(){
        m_userNameLogInput.text = "";
        m_passwordLogInput.text = "";
        m_userNameInput.text = "";
        m_passwordInput.text = "";
        m_passwordConfirmInput.text = "";
        m_ageInput.text = "";
        m_text.text = "";
    }
}