using System;

[Serializable]
public class QuestionData
{
    public string questionText;
    public string[] answers;   // length = 4
    public int correctIndex;   // 0–3
    public QuestionDifficulty difficulty;
}

public enum QuestionDifficulty
{
    Easy,
    Medium,
    Hard
}
