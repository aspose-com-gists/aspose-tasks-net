var credentials = new ProjectServerCredentials("https://xxxxxx.sharepoint.com", "yyyyy@xxxxxxx.onmicrosoft.com", "password");
Guid myProjectGuid = new Guid("2886a8c9-dca7-413c-a57a-b7116cd1bc0f");
ProjectServerManager manager = new ProjectServerManager(credentials);
var project = manager.GetProject(myProjectGuid);

// modification of the project
project.RootTask.Children.Add("New task");

manager.UpdateProject(project);
