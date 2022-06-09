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
  addform(newForm:Contact): Observable<Contact>{
    // uploadFile()
    return this.http.post<Contact>("https://localhost:44307/api/Contact/Contact", newForm)
  }


  // //update
  // update(newUser: SignUp): Observable<User> {
  //   return this.http.post<User>("https://localhost:44307/api/User/SignUp", newUser)
  // }

   //שליחת תמונה
   upload(file: any): Observable<string> {

    // Create form data
    const formData = new FormData();

    // Store form name as "file" with file data
    formData.append('file', file);

    // Make http post request over api
    // with formData as req
    return this.http.post<string>("https://localhost:44307/api/File/upload", formData);
  }



  // public uploadFile(voters: File, electionId: number): Observable<Object> {
  //   let formData = new FormData();
  //   formData.append('voters', voters);
  //   formData.append('electionId', electionId.toString());
  //   return this.http.post(`https://localhost:44307/api/User/loadPictures`, formData);
  // }
}

function uploadFile() {
  throw new Error('Function not implemented.');
}

