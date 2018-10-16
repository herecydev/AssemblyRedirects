# Demonstration of AppDomain issues with binding redirects

## How to trigger issue

1. Run application (AssemblyRedirects/Program.cs) to prove it works fine and check Debug->Modules to see different Json versions loaded correctly into their respective appdomains
2. Uncomment Program.cs L12 and the project reference in the csproj
3. Run again, should see missing method exception
4. Also notice that Json v11 is being pulled into the new appdomain (probably as a result of the binding)