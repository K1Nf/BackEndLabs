﻿namespace BackEndLabs.Contracts
{
    public class PermissionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}
