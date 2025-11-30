using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public enum GameMode
{
    Standard,
    Eternal
}

public class QuizController : MonoBehaviour
{
    public Color correctColor = new Color(0.2f, 0.8f, 0.2f); 
    public Color wrongColor = new Color(0.9f, 0.2f, 0.2f); 
    public Color defaultColor = Color.white;
    public Color flashCorrect = new Color(0f, 1f, 0f, 0.35f);
    public Color flashWrong = new Color(1f, 0f, 0f, 0.35f);

    public Image flashOverlay;

    private bool inputLocked = false; 

    public AudioClip correctSfx;
    public AudioClip wrongSfx;



    [Header("UI References")]
    public TMP_Text questionText;
    public TMP_Text[] answerTexts;
    public TMP_Text progressText;

    [Header("Timer UI")]
    public Slider timerSlider;       
    public TMP_Text timerText;           
    public float questionTimeLimit = 10f; 

    private float timeRemaining;          
    private bool isTiming;                

    private QuestionData currentQuestion;

    private void OnEnable()
    {
        LoadCurrentQuestion();
    }

    private void Update()  
    {
        if (!isTiming) return;

        timeRemaining -= Time.deltaTime;
        if (timeRemaining < 0f) timeRemaining = 0f;

        if (timerSlider != null)
            timerSlider.value = timeRemaining;

        if (timerText != null)
            timerText.text = Mathf.CeilToInt(timeRemaining).ToString();

        if (timeRemaining <= 0f)
        {
            isTiming = false;
            StartCoroutine(HandleTimeout()); 
        }
    }

    private void LoadCurrentQuestion()
    {
        currentQuestion = GameManager.Instance.GetCurrentQuestion();

        if (currentQuestion == null)
        {
            UIManager.Instance.ShowResults();
            return;
        }

        questionText.text = currentQuestion.questionText;

        for (int i = 0; i < answerTexts.Length; i++)
        {
            answerTexts[i].text = currentQuestion.answers[i];
        }

        var gm = GameManager.Instance;

        if (gm.CurrentMode == GameMode.Standard)
        {
            int current = gm.currentQuestionIndex + 1;
            int total = gm.currentRunQuestions.Count;
            progressText.text = $"{current} / {total}";
        }
        else
        {
            progressText.text = $"Streak: {gm.correctCount}";
        }

        StartTimer();
    }



    private void StartTimer()
    {
        timeRemaining = questionTimeLimit;
        isTiming = true;

        if (timerSlider != null)
        {
            timerSlider.maxValue = questionTimeLimit;
            timerSlider.value = questionTimeLimit;
        }

        if (timerText != null)
        {
            timerText.text = Mathf.CeilToInt(timeRemaining).ToString();
        }
    }

    public void StopTimer()
    {
        isTiming = false;
    }


    public void OnAnswerSelected(int index)
    {
        if (inputLocked) return;

        StartCoroutine(PunchButton(answerTexts[index].transform.parent));

        if (currentQuestion == null) return;

        StopTimer();

        bool isCorrect = (index == currentQuestion.correctIndex);

        StartCoroutine(HandleAnswerFeedback(index, isCorrect));
    }


    private IEnumerator HandleTimeout()
    {
        yield return StartCoroutine(HandleAnswerFeedback(-1, false));
    }


    private IEnumerator HandleAnswerFeedback(int index, bool isCorrect)
    {
        inputLocked = true;

        Image correctImg = answerTexts[currentQuestion.correctIndex].transform.parent.GetComponent<Image>();
        correctImg.color = correctColor;

        for (int i = 0; i < answerTexts.Length; i++)
        {
            if (i == currentQuestion.correctIndex) continue;

            Image wrongImg = answerTexts[i].transform.parent.GetComponent<Image>();
            wrongImg.color = wrongColor;
        }

        StartCoroutine(FlashScreen(isCorrect));

        if (isCorrect)
            GameManager.Instance.correctCount++;

        if (isCorrect)
            SfxManager.Instance.PlaySfx(correctSfx);
        else
            SfxManager.Instance.PlaySfx(wrongSfx);

        yield return new WaitForSeconds(1.5f);

        for (int i = 0; i < answerTexts.Length; i++)
        {
            Image img = answerTexts[i].transform.parent.GetComponent<Image>();
            img.color = defaultColor;
        }

        inputLocked = false;

        var gm = GameManager.Instance;

        if (gm.CurrentMode == GameMode.Eternal)
        {
            if (isCorrect)
            {
                gm.currentQuestionIndex++;

                if (gm.currentQuestionIndex >= gm.currentRunQuestions.Count)
                    gm.currentQuestionIndex = 0;

                LoadCurrentQuestion();
            }
            else
            {
                gm.UpdateBestEternalStreak();
                UIManager.Instance.ShowResults();
            }
        }
        else
        {
            if (gm.HasMoreQuestions())
            {
                gm.currentQuestionIndex++;
                LoadCurrentQuestion();
            }
            else
            {
                UIManager.Instance.ShowResults();
            }
        }
    }


    private IEnumerator FlashScreen(bool correct)
    {
        Color target = correct ? flashCorrect : flashWrong;

        flashOverlay.color = target;

        yield return new WaitForSeconds(0.2f);

        float duration = 0.3f;
        float t = 0f;

        while (t < duration)
        {
            flashOverlay.color = Color.Lerp(target, Color.clear, t / duration);
            t += Time.deltaTime;
            yield return null;
        }

        flashOverlay.color = Color.clear;
    }

    private IEnumerator PunchButton(Transform button)
    {
        Vector3 startScale = button.localScale;
        Vector3 bigScale = startScale * 1.08f;

        float t = 0f;
        float speed = 8f;

        while (t < 1)
        {
            button.localScale = Vector3.Lerp(startScale, bigScale, Mathf.Sin(t * Mathf.PI));
            t += Time.deltaTime * speed;
            yield return null;
        }

        button.localScale = startScale;
    }



}

