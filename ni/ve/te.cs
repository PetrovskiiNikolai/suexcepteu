public static StateStorage Load(string key)
{
    if (string.IsNullOrEmpty(key))
    {
        throw new ArgumentException("Key cannot be null or empty.", nameof(key));
    }

    try
    {
        // Assuming data is stored in a file with the key as the filename.
        var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, key + ".dat");
        if (File.Exists(filePath))
        {
            var data = File.ReadAllText(filePath);
            var stateStorage = JsonConvert.DeserializeObject<StateStorage>(data);
            return stateStorage;
        }
        else
        {
            // Handle the case where the file does not exist.
            return null;
        }
    }
    catch (Exception ex)
    {
        // Log the exception details and handle it appropriately.
        // This could be logging to a file, or rethrowing the exception, etc.
        throw new ApplicationException("An error occurred while loading the state storage.", ex);
    }
}
