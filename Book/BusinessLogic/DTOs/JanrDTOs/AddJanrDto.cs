﻿namespace Book.BusinessLogic.DTOs.JanrDTOs;

public class AddJanrDto
{
    public string Name { get; set; } = null!;
    public IFormFile file { get; set; } = null!;
}
