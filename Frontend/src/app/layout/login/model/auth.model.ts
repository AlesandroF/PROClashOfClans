export class AuthModel {
    private constructor(public UserName: string, public Password: string) { }

    static CreateInstance(username: string, password: string): AuthModel {
        return new AuthModel(username, password);
    }
}
