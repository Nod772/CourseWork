using System.Collections.Generic;

namespace Teacher.Class
{
    class Question
    {
        int Id { get; }
        string TextQuestion { get; set; }
        double Score { get; set; }
        List<AnswerOption> AnswerList { get; }

    }
}
