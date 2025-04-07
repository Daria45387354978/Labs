var result = students
    .OrderBy(s => s.Name)
    .Where(s => s.Age > 18)
    .Select(s => s.Name);
