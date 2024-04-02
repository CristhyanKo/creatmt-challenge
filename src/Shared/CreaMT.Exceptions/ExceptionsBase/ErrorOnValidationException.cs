﻿namespace CreaMT.Exceptions.ExceptionsBase;
public class ErrorOnValidationException : CreaMTException
{
    public IList<string> ErrorsMessages { get; set; }

    public ErrorOnValidationException(IList<string> errorsMessages)
    {
        ErrorsMessages = errorsMessages;
    }
}
