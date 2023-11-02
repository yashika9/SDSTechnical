import React from "react";
import "./LoginAttemptList.css";

const LoginAttempt = (props) => (
	props.children.map(item => <li className="Attempt-list-Left">{item}</li>));
	
const LoginAttemptList = (props) => (
	<div className="Attempt-List-Main">
	 	<p>Recent activity</p>
	  	<input type="input" placeholder="Filter..." />
		<ul className="Attempt-List">
				<LoginAttempt>{props.attempts}</LoginAttempt>			
		</ul>
	</div>
);

export default LoginAttemptList;