﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pollars.Dtos
{
	public class UserDto : BaseDto
	{
		public string Name { get; set; }
		public string Lastname { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
	}
}
