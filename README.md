ActiveDirectoryPasswordRecycler
===============================

Allows an Active Directory User to recycle through the password history of the Active Directory to keep the password they want.

Features:

1. Add multiple domain connections.
2. Test domain connections.
3. Change password once;
4. Change password in recycle mode (default). This changes your password by adding a "*" and an iteration number to your new password before settling on your final new password.
For instance, if you are changing your password to "MyNewPass", and you were recycling with 24 iterations (default), the first password change would be "MyNewPass*1", then "MyNewPass*2", etc. until it finally finished with "MyNewPass".

