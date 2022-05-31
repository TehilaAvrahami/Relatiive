import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SignUp } from '../model/SignUp';
import { Observable } from 'rxjs/internal/Observable';
import { SignIn } from '../model/SignIn';
import { User } from '../model/User';
import { Contact } from '../model/Contact';

@Injectable({
  providedIn: 'root'
})
export class DbService {

  user: User = new User()
  
  constructor(private http: HttpClient) { }
  //sign-up
  addUser(newUser: SignUp): Observable<User> {
    return this.http.post<User>("https://localhost:44307/api/User/SignUp", newUser)
  }

  //LOGIN
  loginUser(login: SignIn): Observable<User> {
     return this.http.post<User>("https://localhost:44307/api/User/SignIn", login)
  } 

  //contact form
  addForm(newForm:Contact): Observable<Contact>{
    return this.http.post<Contact>("https://localhost:44307/api/User/Contact", newForm)
  }


  public uploadFile(voters: File, electionId: number): Observable<Object> {
    let formData = new FormData();
    formData.append('voters', voters);
    formData.append('electionId', electionId.toString());
    return this.http.post(`https://localhost:44307/api/User/loadPictures`, formData);
  }
}

