﻿namespace CreaMT.Domain.Security.Cryptography;
public interface IPasswordEncripter
{
    public string Encrypt(string password);
}
