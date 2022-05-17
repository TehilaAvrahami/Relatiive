import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SignUp } from '../model/SignUp';
import { Observable } from 'rxjs/internal/Observable';
import { SignIn } from '../model/SignIn';

@Injectable({
  providedIn: 'root'
})
export class DbService {

  constructor(private http: HttpClient) { }
  //sign-up
  addUser(newUser: SignUp): Observable<SignUp> {
    return this.http.post<SignUp>("https://localhost:44307/api/User/SignUp", newUser)
  }

  //LOGIN
  loginUser(login: SignIn): Observable<SignIn> {
    return this.http.post<SignIn>("https://localhost:44307/api/User/SignIn", login)
  }

  public uploadFile(voters: File, electionId: number): Observable<Object> {
    let formData = new FormData();
    formData.append('voters', voters);
    formData.append('electionId', electionId.toString());
    return this.http.post(`https://localhost:44307/api/User/loadPictures`, formData);
  }
}

