﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace AspNetCore_QnA_Bot.AppInsights
{
    /// <summary>
    /// The Application Insights property names that we're logging.
    /// </summary>
    public static class MyQnaConstants
    {
        public const string ActivityIdProperty = "ActivityId";
        public const string UsernameProperty = "Username";
        public const string ConversationIdProperty = "ConversationId";
        public const string OriginalQuestionProperty = "OriginalQuestion";
        public const string QuestionProperty = "Question";
        public const string AnswerProperty = "Answer";
        public const string ScoreProperty = "Score";
    }
}